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
    public partial class frmrezervonay : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=94.73.146.4;Initial Catalog=u7173324_iMRRS; User Id=u7173324_team5;Password=NVgq59B4ZZhn33X;");
        public frmrezervonay()
        {
            InitializeComponent();
        }

        private void frmrezervonay_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = yenile1();
            dataGridView2.DataSource = yenile2();
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
        }
        DataTable yenile1()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select RRID,datResRequest.RoomID,datRoom.RName,substring(ResSDT,1,4)+'-'+substring(ResSDT,5,2)+'-'+substring(ResSDT,7,2)+' '+substring(ResSDT,9,2)+':'+SUBSTRING(ResSDT,11,2) as 'Rezervasyon Başlangıç Tarihi', substring(ResEDT,1,4)+'-'+substring(ResEDT,4,2)+'-'+substring(ResEDT,6,2)+' '+substring(ResEDT,9,2)+':'+SUBSTRING(ResEDT,11,2)as 'Rezervasyon Bitiş Tarihi',datResRequest.UserID,datUser.UserFName,datUser.UserLName,RezervOnay from datResRequest inner join datUser on datResRequest.UserID=datUser.UserID inner join datRoom on datResRequest.RoomID=datRoom.RoomID where RezervOnay=0", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            baglanti.Close();
            return dt;
        }
        DataTable yenile2()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select RRID,datResRequest.RoomID,datRoom.RName,substring(ResSDT,1,4)+'-'+substring(ResSDT,5,2)+'-'+substring(ResSDT,7,2)+' '+substring(ResSDT,9,2)+':'+SUBSTRING(ResSDT,11,2) as 'Rezervasyon Başlangıç Tarihi', substring(ResEDT,1,4)+'-'+substring(ResEDT,4,2)+'-'+substring(ResEDT,6,2)+' '+substring(ResEDT,9,2)+':'+SUBSTRING(ResEDT,11,2)as 'Rezervasyon Bitiş Tarihi',datResRequest.UserID,datUser.UserFName,datUser.UserLName,RezervOnay from datResRequest inner join datUser on datResRequest.UserID=datUser.UserID inner join datRoom on datResRequest.RoomID=datRoom.RoomID where RezervOnay=1", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            baglanti.Close();
            return dt;
        }
        SqlCommand vo_Command2;
        int rezervonay1 = 1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            
            int secilenalan = dataGridView1.SelectedCells[0].RowIndex;
            int rrid = Convert.ToInt32(dataGridView1.Rows[secilenalan].Cells[2].Value.ToString());
            if (e.ColumnIndex==0)
            {
                if (MessageBox.Show("Bu rezervasyonu onaylamak istediğinize emin misiniz?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    vo_Command2 = new SqlCommand();
                    baglanti.Open();

                    vo_Command2.Connection = baglanti;
                    vo_Command2.CommandText = "update datResRequest set RezervOnay='" + rezervonay1 + "' where RRID='" + rrid + "'";
                    vo_Command2.ExecuteNonQuery();
                    baglanti.Close();

                    //baglanti.Open();
                    //SqlCommand komut = new SqlCommand("update datResRequest set RezervOnay='1' where='" + rrid+"' ");
                    //baglanti.Close();
                    dataGridView1.DataSource = yenile1();
                    dataGridView2.DataSource = yenile2();
                }
                
            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Bu rezervasyonu silmek istediğinize emin misiniz?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vo_Command2 = new SqlCommand();
                    baglanti.Open();

                    vo_Command2.Connection = baglanti;
                    vo_Command2.CommandText = "delete from datResRequest where RRID='" + rrid + "'";
                    vo_Command2.ExecuteNonQuery();
                    baglanti.Close();
                    dataGridView1.DataSource = yenile1();
                    dataGridView2.DataSource = yenile2();
                }

            }
        }
    }
}
