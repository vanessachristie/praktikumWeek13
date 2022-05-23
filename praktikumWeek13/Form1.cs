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
            sqlQuery = "SELECT p.player_id,p.player_name,p.birthdate,p.nationality_id,p.team_id,p.team_number FROM player_vanessa p";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
            
            sqlQuery = "SELECT n.nation as `Nation`, nationality_id as `Nationality ID` FROM nationality n ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain2);
            cBoxNation.DataSource = dtTypePemain2;
            cBoxNation.DisplayMember = "Nation";
            cBoxNation.ValueMember = "nationality Id";


            sqlQuery = "SELECT team_name, team_id FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain3);

            cBoxTeam.DataSource = dtTypePemain3;
            cBoxTeam.DisplayMember = "team_name";
            cBoxTeam.ValueMember = "team_id";

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
            try
            {
                tBoxID.Text = dtTypePemain.Rows[Posisi][0].ToString();
                tBoxName.Text = dtTypePemain.Rows[Posisi][1].ToString();
                BirthDate.Text = dtTypePemain.Rows[Posisi][2].ToString();
                
                cBoxNation.SelectedValue = dtTypePemain.Rows[Posisi][3].ToString();
                cBoxTeam.SelectedValue = dtTypePemain.Rows[Posisi][4].ToString();
                numTeamNumb.Text = dtTypePemain.Rows[Posisi][5].ToString();

                PosisiSekarang = Posisi;
            }
            catch (Exception)
            {

                
            }
            
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
            TeamNumber();
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
               
                sqlQuery = $"UPDATE player_vanessa SET player_name = '" + tBoxName.Text + "', team_number = '" + numTeamNumb.Value.ToString() + "', nationality_id = '" + cBoxNation.SelectedValue.ToString() + "', team_id = '" + cBoxTeam.SelectedValue.ToString() + "' where player_id = '" + tBoxID.Text + "' ";
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
