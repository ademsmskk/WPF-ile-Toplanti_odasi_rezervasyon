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
    public partial class frmrezervasyonlarım : Form
    {
        public frmrezervasyonlarım()
        {
            InitializeComponent();
        }
        public int userid2;
        SqlConnection baglanti = new SqlConnection("Data Source=94.73.146.4;Initial Catalog=u7173324_iMRRS; User Id=u7173324_team5;Password=NVgq59B4ZZhn33X;");
        private void frmrezervasyonlarım_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = yenile2();
            dataGridView1.ReadOnly = true;
            dataGridView2.DataSource = yenile1();
            dataGridView2.ReadOnly = true;

        }
        DataTable yenile2()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select RRID,datResRequest.RoomID,datRoom.RName,substring(ResSDT,1,4)+'-'+substring(ResSDT,5,2)+'-'+substring(ResSDT,7,2)+' '+substring(ResSDT,9,2)+':'+SUBSTRING(ResSDT,11,2) as 'Rezervasyon Başlangıç Tarihi', substring(ResEDT,1,4)+'-'+substring(ResEDT,4,2)+'-'+substring(ResEDT,6,2)+' '+substring(ResEDT,9,2)+':'+SUBSTRING(ResEDT,11,2)as 'Rezervasyon Bitiş Tarihi',datResRequest.UserID,datUser.UserFName,datUser.UserLName,RezervOnay from datResRequest inner join datUser on datResRequest.UserID=datUser.UserID inner join datRoom on datResRequest.RoomID=datRoom.RoomID where datResRequest.UserID ='" + userid2+"' and RezervOnay=1", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            baglanti.Close();
            return dt;
        }
        DataTable yenile1()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select RRID,datResRequest.RoomID,datRoom.RName,substring(ResSDT,1,4)+'-'+substring(ResSDT,5,2)+'-'+substring(ResSDT,7,2)+' '+substring(ResSDT,9,2)+':'+SUBSTRING(ResSDT,11,2) as 'Rezervasyon Başlangıç Tarihi', substring(ResEDT,1,4)+'-'+substring(ResEDT,4,2)+'-'+substring(ResEDT,6,2)+' '+substring(ResEDT,9,2)+':'+SUBSTRING(ResEDT,11,2)as 'Rezervasyon Bitiş Tarihi',datResRequest.UserID,datUser.UserFName,datUser.UserLName,RezervOnay from datResRequest inner join datUser on datResRequest.UserID=datUser.UserID inner join datRoom on datResRequest.RoomID=datRoom.RoomID where datResRequest.UserID ='" + userid2 + "' and RezervOnay=0", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            baglanti.Close();
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
