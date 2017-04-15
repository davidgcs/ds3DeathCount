using DarkSouls_DeathCount.DeathCount;
using IgroGadgets.Memory;
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
            catch (NoAdminPrivilegesException)
            {
                DialogResult ok = MessageBox.Show("Insufficient permissions. Try it again with admin rights.", "Error");

                Environment.Exit(0);
            }
            catch (NoProcessFoundException)
            {
                DialogResult ok = MessageBox.Show("The game is not running. Start the game before launching the application.", "Error");

                Environment.Exit(0);
            }

            //starts the process that count deaths every .5 seconds
            new Thread(new ThreadStart(runThread)).Start();
        }

        private void runThread()
        {
            while (!end)
            {
                Thread.Sleep(500);

                if (this.lblDeaths.InvokeRequired)
                {
                    this.lblDeaths.BeginInvoke((MethodInvoker)delegate () { this.lblDeaths.Text = DeathCounter.GetDeaths().ToString(); ; });
                }
                else
                {
                    this.lblDeaths.Text = DeathCounter.GetDeaths().ToString(); ;
                }            
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
