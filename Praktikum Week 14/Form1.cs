using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_Week_14
{
    public partial class FormTeam : Form
    {
        public FormTeam()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTypePemain = new DataTable();
        int PosisiSekarang = 0;

        private void FormTeam_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT t.team_name as `Nama Tim`, CONCAT(m.manager_name,' ','(',n.nation,')'),CONCAT(home_stadium,',',' ',city,' ','(',capacity,')') FROM team t, manager m, player p, nationality n WHERE t.manager_id = m.manager_id AND m.nationality_id = n.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
            IsiDataPemain(0);
        }

        public void IsiDataPemain(int Posisi)
        {
            lblTeamName.Text = dtTypePemain.Rows[Posisi][0].ToString();
            lblManager.Text = dtTypePemain.Rows[Posisi][1].ToString();
            lblStadium.Text = dtTypePemain.Rows[Posisi][2].ToString();
            //lTopScorer.Text = dtTypePemain.Rows[Posisi][3].ToString();
            //lWorstDescipline.Text = dtTypePemain.Rows[Posisi][4].ToString();
            PosisiSekarang = Posisi;
        }

        private void labelTeamName_Click(object sender, EventArgs e)
        {

        }

        private void labelManager_Click(object sender, EventArgs e)
        {

        }

        private void labelStadium_Click(object sender, EventArgs e)
        {

        }

        private void labelTopScorer_Click(object sender, EventArgs e)
        {

        }

        private void buttonPertama_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void buttonTerakhir_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtTypePemain.Rows.Count - 1);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Sudah Data Pertama");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTypePemain.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Sudah Data Terakhir");
            }
        }
    }
}
