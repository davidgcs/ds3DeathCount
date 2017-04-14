namespace DarkSouls_DeathCount
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.setDeathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDeaths = new System.Windows.Forms.TextBox();
            this.lblDisableFocus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.85714F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(339, 690);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 74);
            this.label1.TabIndex = 3;
            this.label1.Text = "TIMES";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 38);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDeathsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(72, 34);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DarkSouls_DeathCount.Properties.Resources.You_Died;
            this.pictureBox1.Location = new System.Drawing.Point(59, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // setDeathsToolStripMenuItem
            // 
            this.setDeathsToolStripMenuItem.Name = "setDeathsToolStripMenuItem";
            this.setDeathsToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.setDeathsToolStripMenuItem.Text = "Set Deaths";
            this.setDeathsToolStripMenuItem.Click += new System.EventHandler(this.setDeathsToolStripMenuItem_Click);
            // 
            // lblDeaths
            // 
            this.lblDeaths.BackColor = System.Drawing.Color.Black;
            this.lblDeaths.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDeaths.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.85714F);
            this.lblDeaths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.lblDeaths.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDeaths.Location = new System.Drawing.Point(259, 488);
            this.lblDeaths.Margin = new System.Windows.Forms.Padding(4);
            this.lblDeaths.MaxLength = 2147483647;
            this.lblDeaths.Multiline = true;
            this.lblDeaths.Name = "lblDeaths";
            this.lblDeaths.ReadOnly = true;
            this.lblDeaths.ShortcutsEnabled = false;
            this.lblDeaths.Size = new System.Drawing.Size(378, 81);
            this.lblDeaths.TabIndex = 5;
            this.lblDeaths.TabStop = false;
            this.lblDeaths.Text = "0";
            this.lblDeaths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblDeaths.Click += new System.EventHandler(this.lblDeaths_Click);
            // 
            // lblDisableFocus
            // 
            this.lblDisableFocus.AutoSize = true;
            this.lblDisableFocus.Enabled = false;
            this.lblDisableFocus.Location = new System.Drawing.Point(699, 930);
            this.lblDisableFocus.Name = "lblDisableFocus";
            this.lblDisableFocus.Size = new System.Drawing.Size(198, 25);
            this.lblDisableFocus.TabIndex = 6;
            this.lblDisableFocus.Text = "davinxy01 & igromanru";
            this.lblDisableFocus.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(909, 964);
            this.Controls.Add(this.lblDisableFocus);
            this.Controls.Add(this.lblDeaths);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(933, 1116);
            this.MinimumSize = new System.Drawing.Size(933, 1028);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dark Souls III - Death Count";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDeathsToolStripMenuItem;
        private System.Windows.Forms.TextBox lblDeaths;
        private System.Windows.Forms.Label lblDisableFocus;
    }
}

