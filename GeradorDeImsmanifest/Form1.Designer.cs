namespace Taticas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarScormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroDeSuporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaçãoToolStripMenuItem,
            this.programaçãoToolStripMenuItem1,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 32);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programaçãoToolStripMenuItem
            // 
            this.programaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.programaçãoToolStripMenuItem.Image = global::Taticas.Properties.Resources.ico_file;
            this.programaçãoToolStripMenuItem.Name = "programaçãoToolStripMenuItem";
            this.programaçãoToolStripMenuItem.Size = new System.Drawing.Size(85, 28);
            this.programaçãoToolStripMenuItem.Text = "Arquivo";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Image = global::Taticas.Properties.Resources.ico_settings;
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.configToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.configToolStripMenuItem.Text = "Configurações";
            this.configToolStripMenuItem.Visible = false;
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::Taticas.Properties.Resources.ico_exit;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // programaçãoToolStripMenuItem1
            // 
            this.programaçãoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarScormToolStripMenuItem});
            this.programaçãoToolStripMenuItem1.Image = global::Taticas.Properties.Resources.ico_programacao;
            this.programaçãoToolStripMenuItem1.Name = "programaçãoToolStripMenuItem1";
            this.programaçãoToolStripMenuItem1.Size = new System.Drawing.Size(114, 28);
            this.programaçãoToolStripMenuItem1.Text = "Programação";
            // 
            // gerarScormToolStripMenuItem
            // 
            this.gerarScormToolStripMenuItem.Image = global::Taticas.Properties.Resources.ico_package;
            this.gerarScormToolStripMenuItem.Name = "gerarScormToolStripMenuItem";
            this.gerarScormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.gerarScormToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.gerarScormToolStripMenuItem.Text = "Gerar Scorm";
            this.gerarScormToolStripMenuItem.Click += new System.EventHandler(this.gerarScormToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centroDeSuporteToolStripMenuItem,
            this.atualizaçãoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Image = global::Taticas.Properties.Resources.ico_help;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(74, 28);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // centroDeSuporteToolStripMenuItem
            // 
            this.centroDeSuporteToolStripMenuItem.Image = global::Taticas.Properties.Resources.ico_pdf;
            this.centroDeSuporteToolStripMenuItem.Name = "centroDeSuporteToolStripMenuItem";
            this.centroDeSuporteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.centroDeSuporteToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.centroDeSuporteToolStripMenuItem.Text = "Documentação";
            this.centroDeSuporteToolStripMenuItem.Click += new System.EventHandler(this.centroDeSuporteToolStripMenuItem_Click);
            // 
            // atualizaçãoToolStripMenuItem
            // 
            this.atualizaçãoToolStripMenuItem.Image = global::Taticas.Properties.Resources.ico_updates;
            this.atualizaçãoToolStripMenuItem.Name = "atualizaçãoToolStripMenuItem";
            this.atualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.atualizaçãoToolStripMenuItem.Text = "Atualização";
            this.atualizaçãoToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = global::Taticas.Properties.Resources.ico_about;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.sobreToolStripMenuItem.Text = "Sobre a WT";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslHora,
            this.tsslData,
            this.tsslVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslHora
            // 
            this.tsslHora.Name = "tsslHora";
            this.tsslHora.Size = new System.Drawing.Size(50, 17);
            this.tsslHora.Text = "tsslHora";
            // 
            // tsslData
            // 
            this.tsslData.Name = "tsslData";
            this.tsslData.Size = new System.Drawing.Size(48, 17);
            this.tsslData.Text = "tsslData";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(63, 17);
            this.tsslVersion.Text = "tsslVersion";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "O programa foi minimizado.";
            this.notifyIcon1.BalloonTipTitle = "Táticas";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Táticas";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taticas.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 622);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Táticas";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.timer1_Tick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslHora;
        private System.Windows.Forms.ToolStripStatusLabel tsslData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem programaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerarScormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroDeSuporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

