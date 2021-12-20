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
    public partial class frmOdaOzellikleri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=94.73.146.4;Initial Catalog=u7173324_iMRRS; User Id=u7173324_team5;Password=NVgq59B4ZZhn33X;");
        public frmOdaOzellikleri()
        {
            InitializeComponent();
        }

        private void frmOdaOzellikleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = yenile();
        }
        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select RoomID,RName, RPCapacity,RProjection,RIBoard,RInternet,RIPTV,RVOIP from datRoom", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            baglanti.Close();
            return dt;
        }
    }
}
