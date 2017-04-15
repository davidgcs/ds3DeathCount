using DarkSouls_DeathCount.DeathCount;
using IgroGadgets.Memory;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DarkSouls_DeathCount
{
    public partial class Form1 : Form
    {
        private int language = 0;
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
                if (language == 0)
                {
                    DialogResult ok = MessageBox.Show("Insufficient permissions. Try it again with admin rights.", "Error");
                }

                if(language == 1)
                {
                    DialogResult ok = MessageBox.Show("Permisos insuficientes. Inténtalo de nuevo ejecutándo como administrador.", "Error");
                }

                Environment.Exit(0);
            }
            catch (NoProcessFoundException)
            {
                if (language == 0)
                {
                    DialogResult ok = MessageBox.Show("The game is not running. Start the game and load a savegame before launching the application.", "Error");
                }

                if (language == 1)
                {
                    DialogResult ok = MessageBox.Show("El juego no esta en funcionamiento. Inicia el juego y selecciona una partida antes de ejecutar la aplicación", "Error");
                }

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

                if (DeathCounter.GetDeaths() != 0) //this save the value after closing the game
                {
                    if (this.lblDeaths.InvokeRequired)
                    {
                        this.lblDeaths.BeginInvoke((MethodInvoker)delegate () { this.lblDeaths.Text = DeathCounter.GetDeaths().ToString(); });
                    }
                    else
                    {
                        this.lblDeaths.Text = DeathCounter.GetDeaths().ToString();
                    }
                }
            }
        }

        private void setDeathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //maybe allow the user to change deaths value in the memory with CheatEngine
            DialogResult dialogResult;

            if (language == 0)
            {
                dialogResult = MessageBox.Show("Are you sure you want to change your deaths number?", "Caution!", MessageBoxButtons.YesNo);
            }
            else
            {
                dialogResult = MessageBox.Show("¿Estás seguro de que quieres cambiar tu número de muertes?", "Cuidado!", MessageBoxButtons.YesNo);
            }

            if (dialogResult == DialogResult.Yes)
            {
                //Must prevent the user to set not a number value - done
                string input;
                if (language == 0)
                {
                    input = Microsoft.VisualBasic.Interaction.InputBox("How many times you died?", "Set deaths", lblDeaths.Text);
                }
                else
                {
                    input = Microsoft.VisualBasic.Interaction.InputBox("¿Cuántas veces has muerto?", "Cambiar muertes", lblDeaths.Text);
                }

                if (!input.Equals(""))
                {
                    try
                    {
                        DeathCounter.SetDeaths(int.Parse(input));
                    }
                    catch (Exception)
                    {
                        if (language == 0)
                        {
                            MessageBox.Show("You must set a numeric value", "Error");
                        }
                        else
                        {
                            MessageBox.Show("Debes dar un valor numérico", "Error");
                        }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Stop all the process & show created by
            end = true;
            if (language == 0)
            {
                MessageBox.Show("Created by davinxy01 and igromanru", "Credits");
            }
            else
            {
                MessageBox.Show("Creado por davinxy01 y igromanru", "Créditos");
            }
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

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = 1;
            englishToolStripMenuItem.Checked = false;
            spanishToolStripMenuItem.Checked = true;

            toolsToolStripMenuItem.Text = "Herramientas";
            setDeathsToolStripMenuItem.Text = "Cambiar Muertes";
            languageToolStripMenuItem.Text = "Idioma";
            exitToolStripMenuItem.Text = "Salir";
            label1.Text = "VECES";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = 0;
            englishToolStripMenuItem.Checked = true;
            spanishToolStripMenuItem.Checked = false;

            toolsToolStripMenuItem.Text = "Tools";
            setDeathsToolStripMenuItem.Text = "Set Deaths";
            languageToolStripMenuItem.Text = "Language";
            exitToolStripMenuItem.Text = "Exit";
            label1.Text = "TIMES";
        }
    }
}
