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
    public partial class frmanaekran : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=94.73.146.4;Initial Catalog=u7173324_iMRRS; User Id=u7173324_team5;Password=NVgq59B4ZZhn33X;");
        


        public frmanaekran()
        {
            InitializeComponent();
        }

        private void frmanaekran_Load(object sender, EventArgs e)
        {
            
            

        }
        
        public void girissorgu()
        {
            
            string vs_Select = "SELECT UserID,UserName,UserPass,UserFName,UserLName,UserEMail,UserType FROM datUser where ";
            vs_Select += "UserName='" + txtuserıd.Text + "' and ";
            vs_Select += "UserPass=" + txtuserpswrd.Text;
            SqlCommand komut = new SqlCommand(vs_Select, baglanti);
            baglanti.Open();
            SqlDataAdapter oku = new SqlDataAdapter();
            oku.SelectCommand = komut;
            DataTable dt = new DataTable();
            oku.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0].Field<string>("UserType") == "1"  || dt.Rows[0].Field<string>("UserType") == "2")
                {

                    frmadminpanel frmadminpanel1 = new frmadminpanel();
                    SqlCommand komutadmin = new SqlCommand("SELECT UserID,UserName,UserFName,UserLName,UserEMail FROM datUser where UserName=@ID and UserPass=@Pass  ", baglanti);
                    komutadmin.Parameters.AddWithValue("ID", txtuserıd.Text);
                    komutadmin.Parameters.AddWithValue("Pass", txtuserpswrd.Text);

                    SqlDataReader oku2 = komutadmin.ExecuteReader();
                    while (oku2.Read())
                    {
                        frmadminpanel1.username2 = (oku2["UserFName"].ToString());
                        frmadminpanel1.userlastname2 = (oku2["UserLName"].ToString());
                        frmadminpanel1.usermail2 = (oku2["UserEMail"].ToString());
                        frmadminpanel1.userid2 = (Convert.ToInt32(oku2["UserID"].ToString()));
                    }
                    oku2.Close();
                    this.Hide();
                    frmadminpanel1.ShowDialog();
                }
                else 
                {
                    frmRezervasyonOlustur frmrezervasyonOlustur = new frmRezervasyonOlustur();
                    frmadminpanel frmadminpanel1 = new frmadminpanel();
                    
                    SqlCommand komutadmin = new SqlCommand("SELECT UserID,UserName,UserFName,UserLName,UserEMail FROM datUser where UserName=@ID and UserPass=@Pass  ", baglanti);
                    komutadmin.Parameters.AddWithValue("ID", txtuserıd.Text);
                    komutadmin.Parameters.AddWithValue("Pass", txtuserpswrd.Text);

                    SqlDataReader oku3 = komutadmin.ExecuteReader();
                    while (oku3.Read())
                    {
                        frmadminpanel1.username2 = (oku3["UserFName"].ToString());
                        frmadminpanel1.userlastname2 = (oku3["UserLName"].ToString());
                        frmadminpanel1.usermail2 = (oku3["UserEMail"].ToString());
                        frmadminpanel1.userid2 = (Convert.ToInt32(oku3["UserID"].ToString()));

                    }
                    oku3.Close();
                    this.Hide();
                    frmadminpanel1.ShowDialog();
                }
                baglanti.Close();
                

            }
            else 
            {
            
                MessageBox.Show("Giriş Hatalı..");
            }




        }

        private void btngiris_Click(object sender, EventArgs e)
        {

            girissorgu();

        }
        private void btnadminpnl_Click(object sender, EventArgs e)
        {


        }
    }
}

