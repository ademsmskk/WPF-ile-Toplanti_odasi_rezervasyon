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
    public partial class odaduzenlekucukekran : Form
    {
        public odaduzenlekucukekran()
        {
            InitializeComponent();
        }
        public int roomid, rpcapacity, rprojection, riboard, rinternet, riptv, rvoip;
        SqlConnection baglanti = new SqlConnection("Data Source=94.73.146.4;Initial Catalog=u7173324_iMRRS; User Id=u7173324_team5;Password=NVgq59B4ZZhn33X;");

        int rinternetindex;
        private void bunifuDropdown4_SelectedIndexChanged(object sender, EventArgs e)
        {
            riboardindex = bunifuDropdown4.SelectedIndex;
        }

        int riptvindex;
        private void bunifuDropdown5_SelectedIndexChanged(object sender, EventArgs e)
        {
            riptvindex = bunifuDropdown5.SelectedIndex;
        }

        int rvoipindex;
        private void bunifuDropdown6_SelectedIndexChanged(object sender, EventArgs e)
        {
            rvoipindex = bunifuDropdown6.SelectedIndex;
        }
        

        int rstatusindex;
        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rstatusindex = bunifuDropdown1.SelectedIndex;
        }
        int riboardindex;

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update datRoom set RName='" +bunifuTextBox2.Text +"',RStatus='"+rstatusindex+"',RPCapacity='" + bunifuTextBox3.Text + "',RProjection='"+rpprojectionindex+"',RIBoard='"+riboard+"',RInternet='"+rinternetindex+"',RIPTV='"+riptvindex+"',RVOIP='"+rvoipindex+"' where RoomID='" + roomid + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();  
            MessageBox.Show("Kayıtlar Yenilendi");
        }

        private void bunifuDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {
            riboardindex = bunifuDropdown3.SelectedIndex;
        }

        int rpprojectionindex;
        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            rpprojectionindex=bunifuDropdown2.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int rstatus;
        public string rname;
        private void odaduzenlekucukekran_Load(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = roomid.ToString();
            bunifuTextBox1.Enabled = false;
            bunifuTextBox2.Text = rname;
            bunifuTextBox3.Text = rpcapacity.ToString();
            if (rstatus == 1)
            {
                bunifuDropdown1.Text = "AÇIK";
            }
            else if (rstatus == 0)
            {
                bunifuDropdown1.Text = "KAPALI";
            }

            if (rprojection == 1)
            {
                bunifuDropdown2.Text = "VAR";
            }
            else if (rprojection == 0)
            {
                bunifuDropdown2.Text = "YOK";
            }

            if (riboard == 1)
            {
                bunifuDropdown3.Text = "VAR";
            }
            else if (riboard == 0)
            {
                bunifuDropdown3.Text = "YOK";
            }
            if (rinternet == 1)
            {
                bunifuDropdown4.Text = "VAR";
            }
            else if (rinternet == 0)
            {
                bunifuDropdown4.Text = "YOK";
            }
            if (riptv == 1)
            {
                bunifuDropdown5.Text = "VAR";
            }
            else if (riptv == 0)
            {
                bunifuDropdown5.Text = "YOK";
            }
            if (rvoip == 1)
            {
                bunifuDropdown6.Text = "VAR";
            }
            else if (rvoip == 0)
            {
                bunifuDropdown6.Text = "YOK";
            }
           


        }
    }
}
