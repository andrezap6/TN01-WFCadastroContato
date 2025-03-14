namespace TN01_WFCadastroContato
{
    partial class lblMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            mnsCadastrar = new ToolStripMenuItem();
            mnsSobre = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            picMenu = new PictureBox();
            mnsListagem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(308, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { mnsCadastrar, mnsSobre, mnsListagem, mnsSair });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(308, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // mnsCadastrar
            // 
            mnsCadastrar.Name = "mnsCadastrar";
            mnsCadastrar.Size = new Size(69, 20);
            mnsCadastrar.Text = "Cadastrar";
            mnsCadastrar.Click += mnsCadastrar_Click;
            // 
            // mnsSobre
            // 
            mnsSobre.Name = "mnsSobre";
            mnsSobre.Size = new Size(49, 20);
            mnsSobre.Text = "Sobre";
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(38, 20);
            mnsSair.Text = "Sair";
            mnsSair.Click += mnsSair_Click_1;
            // 
            // picMenu
            // 
            picMenu.Dock = DockStyle.Right;
            picMenu.Image = Properties.Resources.images;
            picMenu.Location = new Point(7, 48);
            picMenu.Name = "picMenu";
            picMenu.Size = new Size(301, 145);
            picMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            picMenu.TabIndex = 3;
            picMenu.TabStop = false;
            // 
            // mnsListagem
            // 
            mnsListagem.Name = "mnsListagem";
            mnsListagem.Size = new Size(67, 20);
            mnsListagem.Text = "Listagem";
            mnsListagem.Click += mnsListagem_Click;
            // 
            // lblMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 193);
            Controls.Add(picMenu);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "lblMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem mnsCadastrar;
        private ToolStripMenuItem mnsSair;
        private ToolStripMenuItem mnsSobre;
        private PictureBox picMenu;
        private ToolStripMenuItem mnsListagem;
    }
}
