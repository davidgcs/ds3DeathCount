using DarkSouls_DeathCount.DeathCount;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DarkSouls_DeathCount
{
    public partial class Form1 : Form
    {
        private DeathCounter DeathCounter { set; get; }
        
        private bool end = false; 
        public Form1()
        {
            InitializeComponent();
            try
            {
                DeathCounter = new DeathCounter();
            }
            catch(Exception e)
            {
                //I must split this into two messages
                DialogResult ok = MessageBox.Show("Insufficient permissions or the game is not running. Try it again with admin rights.", "Error");

                this.Close();
            }
            
            //starts the process that count deaths every .5 seconds
            new Thread(new ThreadStart(runThread)).Start();            
        }
        
        private void runThread()
        {
            while (!end)
            {
                Thread.Sleep(500);               
                //lblDeaths.Text = new DeathCounter().GetDeaths().ToString();
                Console.WriteLine("thread working");
            }
        }

        private void setDeathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //maybe allow the user to change deaths value in the memory with CheatEngine
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change your deaths number?", "Caution!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Must prevent the user to set not a number value
                string input = Microsoft.VisualBasic.Interaction.InputBox("How many times you died?", "Set deaths", lblDeaths.Text, 0, 0);
                if (!input.Equals(""))
                {
                    DeathCounter.SetDeaths(int.Parse(input));
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Stop all the process & show created by
            end = true;
            MessageBox.Show("Created by davinxy01 and igromanru", "Credits");            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDeaths.Text = DeathCounter.GetDeaths().ToString();
        }

        private void lblDeaths_Click(object sender, EventArgs e)
        {
            this.ActiveControl = lblDisableFocus;
        }
    }
}
