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
    public partial class frmOdaSec : Form
    {
        public frmOdaSec()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=94.73.146.4;Initial Catalog=u7173324_iMRRS; User Id=u7173324_team5;Password=NVgq59B4ZZhn33X;");

        private void frmOdaSec_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = yenile();
            dataGridView1.ReadOnly = true;
        }
        public string userfname, userlastname, useremail;
        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from datRoom", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            baglanti.Close();
            return dt;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            frmRezervasyonOlustur frmRezervasyonOlustur1 = new frmRezervasyonOlustur();
            frmRezervasyonOlustur1.userfname = userfname;
            frmRezervasyonOlustur1.userlastname = userlastname;
            frmRezervasyonOlustur1.useremail = useremail;
            frmRezervasyonOlustur1.roomid = (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmRezervasyonOlustur1.rname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmRezervasyonOlustur1.rpcapacity = (dataGridView1.CurrentRow.Cells[3].Value.ToString());
            frmRezervasyonOlustur1.rprojection = (dataGridView1.CurrentRow.Cells[4].Value.ToString());
            frmRezervasyonOlustur1.riboard = (dataGridView1.CurrentRow.Cells[5].Value.ToString());
            frmRezervasyonOlustur1.rinternet = (dataGridView1.CurrentRow.Cells[6].Value.ToString());
            frmRezervasyonOlustur1.riptv = (dataGridView1.CurrentRow.Cells[7].Value.ToString());
            frmRezervasyonOlustur1.rvoip = (dataGridView1.CurrentRow.Cells[8].Value.ToString());
            frmRezervasyonOlustur1.Refresh();
            this.Hide();
            frmRezervasyonOlustur1.ShowDialog();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
            


        }
    }
}
