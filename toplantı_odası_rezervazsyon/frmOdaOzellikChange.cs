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
    public partial class OdaÖzellikleri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=94.73.146.4;Initial Catalog=u7173324_iMRRS; User Id=u7173324_team5;Password=NVgq59B4ZZhn33X;");
        
        public OdaÖzellikleri()
        {
            InitializeComponent();
        }

        private void OdaÖzellikleri_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = yenile();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = yenile();


        }
        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select RoomID,RName,RStatus, RPCapacity,RProjection,RIBoard,RInternet,RIPTV,RVOIP from datRoom", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            baglanti.Close();
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenalan = dataGridView1.SelectedCells[0].RowIndex;
            int roomid = Convert.ToInt32(dataGridView1.Rows[secilenalan].Cells[1].Value.ToString());
            if (e.ColumnIndex == 0)
            {
                odaduzenlekucukekran odaduzenlekucukekran1 = new odaduzenlekucukekran();
                
                SqlCommand komut = new SqlCommand("select * from datRoom where RoomID='"+roomid+"' ", baglanti);
                baglanti.Open();
                SqlDataReader oku2 = komut.ExecuteReader();
                while (oku2.Read())
                {
                    odaduzenlekucukekran1.roomid = (Convert.ToInt32(oku2["RoomID"].ToString()));
                    odaduzenlekucukekran1.rname = (oku2["RName"].ToString());
                    odaduzenlekucukekran1.rstatus = (Convert.ToInt32(oku2["RStatus"].ToString()));
                    odaduzenlekucukekran1.rpcapacity = (Convert.ToInt32(oku2["RPCapacity"].ToString()));
                    odaduzenlekucukekran1.rprojection = (Convert.ToInt32(oku2["RProjection"].ToString()));
                    odaduzenlekucukekran1.riboard = (Convert.ToInt32(oku2["RIBoard"].ToString()));
                    odaduzenlekucukekran1.rinternet = (Convert.ToInt32(oku2["RInternet"].ToString()));
                    odaduzenlekucukekran1.riptv = (Convert.ToInt32(oku2["RIPTV"].ToString()));
                    odaduzenlekucukekran1.rvoip = (Convert.ToInt32(oku2["RVOIP"].ToString()));

                }
                oku2.Close();
                baglanti.Close();
                odaduzenlekucukekran1.Show();
                



            }
        }
    }
}
