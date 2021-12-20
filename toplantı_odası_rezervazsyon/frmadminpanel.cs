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
    public partial class frmadminpanel : Form
    {
        public frmadminpanel()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void aSDASDToolStripMenuItem1_Click(object sender, EventArgs e)
        { 

            frmOdaSec frmOdaSec = new frmOdaSec();
            frmOdaSec.MdiParent = this;
            frmOdaSec.userfname = username2;
            frmOdaSec.userlastname = userlastname2;
            frmOdaSec.useremail = usermail2;
            frmOdaSec.Show();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=94.73.146.4;Initial Catalog=u7173324_iMRRS; User Id=u7173324_team5;Password=NVgq59B4ZZhn33X;");
        SqlDataReader dr;
        public string usermail2, username2, userlastname2;

        private void aSDSADSADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaÖzellikleri frmodaduzenle = new OdaÖzellikleri();
            frmodaduzenle.MdiParent = this;
            frmodaduzenle.Show();


        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmanaekran frmanaekran = new frmanaekran();
            this.Hide();
            frmanaekran.ShowDialog();

        }
        frmRezervasyonOlustur frmrezervasyonOlustur;
        private void rezervasyonOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            if (frmrezervasyonOlustur == null || frmrezervasyonOlustur.IsDisposed)
            {
                frmrezervasyonOlustur = new frmRezervasyonOlustur();
                frmrezervasyonOlustur.userid2 = userid2;
                frmrezervasyonOlustur.userfname = username2;
                frmrezervasyonOlustur.userlastname = userlastname2;
                frmrezervasyonOlustur.useremail = usermail2;
                frmrezervasyonOlustur.MdiParent = this;
                frmrezervasyonOlustur.Show();
            }
            else 
            {
                frmrezervasyonOlustur.Focus();
            }
            
           
        }

        private void rezervasyonKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrezervonay frmrezervonay = new frmrezervonay();
            frmrezervonay.MdiParent = this;
            frmrezervonay.Show();
        }

        private void rezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrezervasyonduzenle frmrezervasyonduzenle1 = new frmrezervasyonduzenle();
            frmrezervasyonduzenle1.MdiParent = this;
            frmrezervasyonduzenle1.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmrezervasyonlarım frmrezervasyonlarım1 = new frmrezervasyonlarım();
            frmrezervasyonlarım1.userid2 = userid2;
            frmrezervasyonlarım1.MdiParent = this;
            frmrezervasyonlarım1.Show();
        }

        private void oturumKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmanaekran frmanaekran1 = new frmanaekran();
            frmanaekran1.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aSDASDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public int userid2;
        private void frmadminpanel_Load(object sender, EventArgs e)
        {

            
           
            string vs_Select = "SELECT * FROM datUser where ";
            vs_Select += "UserID=" + userid2;
            SqlCommand komut = new SqlCommand(vs_Select, baglanti);
            baglanti.Open();
            SqlDataAdapter oku = new SqlDataAdapter();
            oku.SelectCommand = komut;
            DataTable dt = new DataTable();
            oku.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0].Field<string>("UserType") == "1")
                {
                    frmadminpanel frmadminpanel = new frmadminpanel();
                   
                    baglanti.Close();
                }
                else if (dt.Rows[0].Field<string>("UserType") == "2")
                {
                    frmadminpanel frmadminpanel = new frmadminpanel();
                   
                    baglanti.Close();
                    OdaDuzenToolStripMenuItem.Visible=false;
                    rezervasyonToolStripMenuItem.Visible = false;
                }
                else 
                {
                    frmadminpanel frmadminpanel = new frmadminpanel();
                   
                    baglanti.Close();
                    OdaDuzenToolStripMenuItem.Visible = false;
                    rezervasyonKontrolToolStripMenuItem.Visible = false;
                    rezervasyonToolStripMenuItem.Visible = false;
                }
            }
        }
    }
}
