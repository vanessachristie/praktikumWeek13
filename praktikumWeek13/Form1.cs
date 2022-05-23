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

namespace praktikumWeek13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTypePemain = new DataTable();
        DataTable dtTypePemain2 = new DataTable();
        DataTable dtTypePemain3 = new DataTable();
        DataTable dtTeamAvailable = new DataTable();
        DataTable dtTeamSave = new DataTable();
        int PosisiSekarang = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT p.player_id,p.player_name,p.birthdate,n.nation,t.team_name,p.team_number FROM player_vanessa p,team t, nationality n where p.team_id = t.team_id and p.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
            
            sqlQuery = "SELECT n.nation FROM player_vanessa p,nationality n where  p.nationality_id = n.nationality_id group by 1 ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain2);
            IsiComboBox(0);
            sqlQuery = "SELECT team_name, team_id FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain3);
            IsiComboBox2(0);

            sqlQuery = "select p.player_id as id_lama, p.player_id, p.player_name, p.birthdate, n.nation, t.team_name, p.team_number from player_vanessa p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id group by 1; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamSave);
            

            cBoxTeam.DataSource = dtTypePemain3;
            cBoxTeam.DisplayMember = "team_name";
            cBoxTeam.ValueMember = "team_id";

            tBoxID.Text = IDbefore;
            tBoxName.Text = NameBefore;
            BirthDate.Text = BirthDateBefore;
            cBoxNation.Text = NationBefore;
            cBoxTeam.Text = TeamBefore;
            numTeamNumb.Text = TeamNumberBefore;
            IsiDataPemain(0);

        }
        string IDbefore;
        string NameBefore;
        string BirthDateBefore; 
        string NationBefore;    
        string TeamBefore;
        string TeamNumberBefore;

        public void IsiDataPemain(int Posisi)
        {
            tBoxID.Text = dtTypePemain.Rows[Posisi][0].ToString();
            tBoxName.Text = dtTypePemain.Rows[Posisi][1].ToString();
            BirthDate.Text = dtTypePemain.Rows[Posisi][2].ToString();
            cBoxNation.Text = dtTypePemain.Rows[Posisi][3].ToString();
            cBoxTeam.Text = dtTypePemain.Rows[Posisi][4].ToString();
            numTeamNumb.Text = dtTypePemain.Rows[Posisi][5].ToString();
            PosisiSekarang = Posisi;
        }
        public void IsiComboBox(int Posisi2)
        {
            this.cBoxNation.DataSource = dtTypePemain2;
            cBoxNation.ValueMember = "nation";
            cBoxNation.Text = dtTypePemain2.Rows[Posisi2][0].ToString();
            PosisiSekarang = Posisi2;
            
        }
        public void IsiComboBox2(int Posisi3)
        {
            this.cBoxTeam.DataSource = dtTypePemain3;
            cBoxTeam.ValueMember = "team_name";
            cBoxTeam.Text = dtTypePemain3.Rows[Posisi3][0].ToString();
            PosisiSekarang = Posisi3;

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTypePemain.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtTypePemain.Rows.Count - 1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lavailable_Click(object sender, EventArgs e)
        {

        }

        private void cBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void TeamNumber()
        {
            dtTeamAvailable = new DataTable();
            sqlQuery = $"SELECT * FROM player WHERE team_id='{cBoxTeam.SelectedValue}' and team_number={numTeamNumb.Value}";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamAvailable);

            if (dtTeamAvailable.Rows.Count > 0)
            {
                lavailable.Text = "Not Available";
            }
            else
            {
                lavailable.Text = "Available";
            }
        }

        private void numTeamNumb_ValueChanged(object sender, EventArgs e)
        {
            TeamNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lavailable.Text == "Available")
            {
                sqlQuery = $"UPDATE player SET player_name = '" + tBoxName.Text + "', team_number = '" + numTeamNumb.Value.ToString() + "', nationality_id = '" + cBoxNation.SelectedValue.ToString() + "', team_id = '" + cBoxTeam.SelectedValue.ToString() + "' where player_id = '" + tBoxID.Text + "' ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            else if (lavailable.Text == "Not Available")
            {
                MessageBox.Show("Nomor Tim Tidak Tersedia");
            }



        }
    }
}
