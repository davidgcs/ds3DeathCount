using DarkSouls_DeathCount.DeathCount;
using System;
using System.IO;
using System.Windows.Forms;

namespace DarkSouls_DeathCount
{
    public partial class Form1 : Form
    {
        private DeathCounter DeathCounter { set; get; }

        private string deaths = "0";    
        public Form1()
        {
            InitializeComponent();
            //loadFile();
            DeathCounter = new DeathCounter();
        }

        private void loadFile()
        {
            bool exists = File.Exists("death_count.ds3") ? true : false;

            if (exists)
            {
                //read file
                StreamReader file = File.OpenText("death_count.ds3");
                deaths = file.ReadLine();
                file.Close();             
            }
            else
            {
                //create file
                StreamWriter file = File.CreateText("death_count.ds3");                
                file.Write(deaths);
                file.Close();             
            }

            lblDeaths.Text = deaths;
        }

        private void btnDie_Click(object sender, EventArgs e)
        {
            deaths = (long.Parse(this.lblDeaths.Text) + 1).ToString();
            lblDeaths.Text = deaths;

            StreamWriter file = new StreamWriter("death_count.ds3");
            file.Write(deaths);
            file.Close();
        }

        private void setDeathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String numDeaths = this.lblDeaths.Text;
            DialogResult result = MessageBox.Show("Do you really want to change your death count manually?", "Important", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("How many deaths you have?",
                       "Deaths",
                       numDeaths);
                if (input.Equals("")) //user clicks on cancel
                {
                    this.lblDeaths.Text = numDeaths;
                }
                else
                {
                    lblDeaths.Text = input;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter file = new StreamWriter("death_count.ds3");
            file.Write(lblDeaths.Text);
            file.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDeaths.Text = DeathCounter.GetDeaths().ToString();
        }
    }
}
