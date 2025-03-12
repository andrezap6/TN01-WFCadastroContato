namespace TN01_WFCadastroContato
{
    partial class FormCadastroContato
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
            lblNome = new Label();
            lblSobrenome = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            rdbPessoal = new RadioButton();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            btnVoltar = new Button();
            btnSalvar = new Button();
            textBox1 = new TextBox();
            mkdTelefone = new MaskedTextBox();
            textBox2 = new TextBox();
            txtEmail = new TextBox();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(19, 37);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(252, 37);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(68, 15);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(19, 217);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(19, 123);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(80, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "DDD/Telefone";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(19, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(196, 23);
            txtNome.TabIndex = 1;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(252, 55);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(210, 23);
            txtSobrenome.TabIndex = 2;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(6, 41);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 5;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Location = new Point(180, 113);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(328, 71);
            gbxTipoTelefone.TabIndex = 7;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo de Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(206, 41);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 7;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(106, 41);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 6;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = Properties.Resources.volte;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(334, 279);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(84, 50);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.MiddleLeft;
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.salvar__1_;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(434, 279);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 50);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(19, 93);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 2);
            textBox1.TabIndex = 10;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(19, 141);
            mkdTelefone.Mask = "(99) 000-000000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(100, 23);
            mkdTelefone.TabIndex = 3;
            mkdTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuText;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(19, 199);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(500, 2);
            textBox2.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(19, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(333, 23);
            txtEmail.TabIndex = 8;
            // 
            // FormCadastroContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 343);
            Controls.Add(txtEmail);
            Controls.Add(textBox2);
            Controls.Add(mkdTelefone);
            Controls.Add(textBox1);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            ForeColor = Color.Black;
            Name = "FormCadastroContato";
            Text = "Cadastro Contato";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblSobrenome;
        private Label lblEmail;
        private Label lblTelefone;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private RadioButton rdbPessoal;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private Button btnVoltar;
        private Button btnSalvar;
        private TextBox textBox1;
        private MaskedTextBox mkdTelefone;
        private TextBox textBox2;
        private TextBox txtEmail;
    }
}