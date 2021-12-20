using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace toplantı_odası_rezervazsyon
{
    
    public partial class frmRezervasyonOlustur : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=94.73.146.4;Initial Catalog=u7173324_iMRRS; User Id=u7173324_team5;Password=NVgq59B4ZZhn33X;");
        public frmRezervasyonOlustur()
        {
            InitializeComponent();
        }
        public string rname,username, userlname, usermail, roomid, rpcapacity, rprojection, riboard, rinternet, riptv, rvoip;
        string vs_Query;
        SqlCommand vo_Command;
        int vi_RoomID;
        int vi_Day, vi_Month, vi_Year;
        string vs_ResSDT = "";
        string vs_ResEDT = "";
        private void label11_Click(object sender, EventArgs e)
        {
           
        }
        int rezervonay = 0;
        public int userid2;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            vi_Day = bunifuDatePicker2.Value.Day;
            vi_Month = bunifuDatePicker2.Value.Month;
            vi_Year = bunifuDatePicker2.Value.Year;
            int.TryParse(txtroomid.Text, out vi_RoomID);

            vs_ResSDT = Convert.ToString(vi_Year) + Convert.ToString(vi_Month) + Convert.ToString(vi_Day);
            vs_ResSDT += bunifuDropdown1.Items[bunifuDropdown1.SelectedIndex];
            vs_ResSDT = vs_ResSDT.Replace(":", String.Empty);

            vs_ResEDT = Convert.ToString(vi_Year) + Convert.ToString(vi_Month) + Convert.ToString(vi_Day);
            vs_ResEDT += bunifuDropdown2.Items[bunifuDropdown2.SelectedIndex];
            vs_ResEDT = vs_ResEDT.Replace(":", String.Empty);

           

            string vs_Query = "SELECT * FROM datResRequest WHERE ";
            vs_Query += "RoomID=" + vi_RoomID +  " and ";
            vs_Query += "'"+vs_ResSDT+ "'<ResEDT";

            baglanti.Open();
            SqlCommand komut = new SqlCommand(vs_Query, baglanti);
            SqlDataAdapter oku = new SqlDataAdapter();
            oku.SelectCommand = komut;
            DataTable dt = new DataTable();
            oku.Fill(dt);
            baglanti.Close();
            if (dt.Rows.Count > 0)
            {
                
                MessageBox.Show("Almak İstediğin Saatlerde Oda Dolu");
            }
            else
            {
                
                
                useridcek();
                roomstatus();
                vo_Command = new SqlCommand();
                baglanti.Open();

                vo_Command.Connection = baglanti;
                vo_Command.CommandText = "insert into datResRequest(RoomID,ResSDT,ResEDT,UserID,RStatus,RezervOnay) values(@roomid,@ressdt,@resedt,@userid,@rstatus,@rezervonay)";
                vo_Command.Parameters.AddWithValue("@roomid", vi_RoomID);
                vo_Command.Parameters.AddWithValue("@ressdt", vs_ResSDT);
                vo_Command.Parameters.AddWithValue("@resedt", vs_ResEDT);
                vo_Command.Parameters.AddWithValue("@userid", userid);
                vo_Command.Parameters.AddWithValue("@rstatus", roomstatus1);
                vo_Command.Parameters.AddWithValue("rezervonay", rezervonay);
                MessageBox.Show("Rezarvasyon İşleminiz Gerçekleştirildi");
                vo_Command.ExecuteNonQuery();
                baglanti.Close();

                
            }
                
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            frmOdaSec frmOdaSec = new frmOdaSec();
            frmOdaSec.userfname = userfname;
            frmOdaSec.userlastname = userlastname;
            frmOdaSec.useremail = useremail;
            frmOdaSec.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtroomid_TextChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string userfname, userlastname, useremail;
        int userid, roomstatus1;
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmOdaSec frmOdaSec = new frmOdaSec();
            frmOdaSec.userfname = userfname;
            frmOdaSec.userlastname = userlastname;
            frmOdaSec.useremail = useremail;
            frmOdaSec.ShowDialog();
            

        }

    
        private void button1_Click(object sender, EventArgs e)
        {
          

        }
        public void useridcek()
        {
            baglanti.Open();
            SqlCommand komutadmin = new SqlCommand("SELECT UserID,UserFName,UserLName,UserEMail FROM datUser where UserFName=@userfirstname and UserLName=@userlastname and UserEMail=useremail ", baglanti);
            komutadmin.Parameters.AddWithValue("userfirstname", textBox1.Text);
            komutadmin.Parameters.AddWithValue("userlastname", textBox2.Text);
            komutadmin.Parameters.AddWithValue("useremail", textBox3.Text);
            SqlDataReader oku2 = komutadmin.ExecuteReader();
            while (oku2.Read())
            {
                
                userid = (Convert.ToInt32(oku2["UserID"].ToString()));
            }
            baglanti.Close();
            oku2.Close();
            
        }
        public void roomstatus()
        {
            baglanti.Open();
            SqlCommand komutadmin = new SqlCommand("SELECT RoomID,RStatus FROM datRoom where RoomID=@roomid ", baglanti);
            komutadmin.Parameters.AddWithValue("roomid", txtroomid.Text);
            SqlDataReader oku3 = komutadmin.ExecuteReader();
            while (oku3.Read())
            {

                roomstatus1 = (Convert.ToInt32(oku3["RStatus"].ToString()));
            }
            oku3.Close();
            baglanti.Close();
        }
        private void frmRezervasyonOlustur_Load(object sender, EventArgs e)
        {
           


            



            textBox1.Text = userfname;
            textBox2.Text = userlastname;
            textBox3.Text = useremail;
            txtroomid.Text = roomid;
            txtrname.Text = rname;
            txtrpcapacity.Text = rpcapacity;
            if (rprojection=="1")
            {
                txtrprojection.Text = "VAR";
            }
            else
            {
                txtrprojection.Text = "YOK";
            }
            if (riboard == "1")
            {
                txtriboard.Text = "VAR";
            }
            else
            {
                txtriboard.Text = "YOK";
            }
            if (rinternet == "1")
            {
                txtrinternet.Text = "VAR";
            }
            else
            {
                txtrinternet.Text = "YOK";
            }
            if (riptv == "1")
            {
                txtriptv.Text = "VAR";
            }
            else
            {
                txtriptv.Text = "YOK";
            }
            if (rvoip == "1")
            {
                txtrvoip.Text = "VAR";
            }
            else
            {
                txtrvoip.Text = "YOK";
            }

           

        }
    }
}
