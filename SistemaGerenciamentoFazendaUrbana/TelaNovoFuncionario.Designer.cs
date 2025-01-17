namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaNovoFuncionario
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
            combobox_nfunc_equipe = new ComboBox();
            lbl_nfunc_equipe = new Label();
            txtbox_nfunc_email = new TextBox();
            btn_nfunc_salvar = new Button();
            btn_nfunc_voltar = new Button();
            txtbox_nfunc_nomecompleto = new TextBox();
            lbl_nfunc_email = new Label();
            lbl_nfunc_cpf = new Label();
            lbl_nfunc_nomecompleto = new Label();
            lbl_dadosdofuncionario = new Label();
            lbl_novofuncionario = new Label();
            pictureBox1_novofuncionario = new PictureBox();
            msktxtbox_nfun_cpf = new MaskedTextBox();
            txtbox_nfunc_codigo = new TextBox();
            lbl_nfunc_codigo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_novofuncionario).BeginInit();
            SuspendLayout();
            // 
            // combobox_nfunc_equipe
            // 
            combobox_nfunc_equipe.FormattingEnabled = true;
            combobox_nfunc_equipe.Items.AddRange(new object[] { "Produção", "Vendas", "Recursos Humanos", "Administração" });
            combobox_nfunc_equipe.Location = new Point(27, 334);
            combobox_nfunc_equipe.Name = "combobox_nfunc_equipe";
            combobox_nfunc_equipe.Size = new Size(329, 23);
            combobox_nfunc_equipe.TabIndex = 96;
            // 
            // lbl_nfunc_equipe
            // 
            lbl_nfunc_equipe.AutoSize = true;
            lbl_nfunc_equipe.BackColor = Color.White;
            lbl_nfunc_equipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nfunc_equipe.ForeColor = SystemColors.ControlDarkDark;
            lbl_nfunc_equipe.Location = new Point(27, 316);
            lbl_nfunc_equipe.Name = "lbl_nfunc_equipe";
            lbl_nfunc_equipe.Size = new Size(44, 15);
            lbl_nfunc_equipe.TabIndex = 95;
            lbl_nfunc_equipe.Text = "Equipe";
            // 
            // txtbox_nfunc_email
            // 
            txtbox_nfunc_email.Location = new Point(27, 259);
            txtbox_nfunc_email.Name = "txtbox_nfunc_email";
            txtbox_nfunc_email.Size = new Size(329, 23);
            txtbox_nfunc_email.TabIndex = 94;
            // 
            // btn_nfunc_salvar
            // 
            btn_nfunc_salvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nfunc_salvar.Location = new Point(281, 520);
            btn_nfunc_salvar.Name = "btn_nfunc_salvar";
            btn_nfunc_salvar.Size = new Size(75, 23);
            btn_nfunc_salvar.TabIndex = 93;
            btn_nfunc_salvar.Text = "Salvar";
            btn_nfunc_salvar.UseVisualStyleBackColor = true;
            btn_nfunc_salvar.Click += btn_nfunc_salvar_Click;
            // 
            // btn_nfunc_voltar
            // 
            btn_nfunc_voltar.BackColor = Color.Red;
            btn_nfunc_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nfunc_voltar.ForeColor = SystemColors.Control;
            btn_nfunc_voltar.Location = new Point(27, 520);
            btn_nfunc_voltar.Name = "btn_nfunc_voltar";
            btn_nfunc_voltar.Size = new Size(75, 23);
            btn_nfunc_voltar.TabIndex = 92;
            btn_nfunc_voltar.Text = "Voltar";
            btn_nfunc_voltar.UseVisualStyleBackColor = false;
            btn_nfunc_voltar.Click += btn_nfunc_voltar_Click;
            // 
            // txtbox_nfunc_nomecompleto
            // 
            txtbox_nfunc_nomecompleto.Location = new Point(27, 122);
            txtbox_nfunc_nomecompleto.Name = "txtbox_nfunc_nomecompleto";
            txtbox_nfunc_nomecompleto.Size = new Size(329, 23);
            txtbox_nfunc_nomecompleto.TabIndex = 91;
            // 
            // lbl_nfunc_email
            // 
            lbl_nfunc_email.AutoSize = true;
            lbl_nfunc_email.BackColor = Color.White;
            lbl_nfunc_email.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nfunc_email.ForeColor = SystemColors.ControlDarkDark;
            lbl_nfunc_email.Location = new Point(27, 241);
            lbl_nfunc_email.Name = "lbl_nfunc_email";
            lbl_nfunc_email.Size = new Size(41, 15);
            lbl_nfunc_email.TabIndex = 89;
            lbl_nfunc_email.Text = "E-mail";
            // 
            // lbl_nfunc_cpf
            // 
            lbl_nfunc_cpf.AutoSize = true;
            lbl_nfunc_cpf.BackColor = Color.White;
            lbl_nfunc_cpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nfunc_cpf.ForeColor = SystemColors.ControlDarkDark;
            lbl_nfunc_cpf.Location = new Point(27, 169);
            lbl_nfunc_cpf.Name = "lbl_nfunc_cpf";
            lbl_nfunc_cpf.Size = new Size(27, 15);
            lbl_nfunc_cpf.TabIndex = 88;
            lbl_nfunc_cpf.Text = "CPF";
            // 
            // lbl_nfunc_nomecompleto
            // 
            lbl_nfunc_nomecompleto.AutoSize = true;
            lbl_nfunc_nomecompleto.BackColor = Color.White;
            lbl_nfunc_nomecompleto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nfunc_nomecompleto.ForeColor = SystemColors.ControlDarkDark;
            lbl_nfunc_nomecompleto.Location = new Point(27, 104);
            lbl_nfunc_nomecompleto.Name = "lbl_nfunc_nomecompleto";
            lbl_nfunc_nomecompleto.Size = new Size(98, 15);
            lbl_nfunc_nomecompleto.TabIndex = 87;
            lbl_nfunc_nomecompleto.Text = "Nome Completo";
            // 
            // lbl_dadosdofuncionario
            // 
            lbl_dadosdofuncionario.AutoSize = true;
            lbl_dadosdofuncionario.BackColor = Color.White;
            lbl_dadosdofuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dadosdofuncionario.ForeColor = Color.Green;
            lbl_dadosdofuncionario.Location = new Point(27, 63);
            lbl_dadosdofuncionario.Name = "lbl_dadosdofuncionario";
            lbl_dadosdofuncionario.Size = new Size(177, 21);
            lbl_dadosdofuncionario.TabIndex = 86;
            lbl_dadosdofuncionario.Text = "Dados do Funcionario";
            // 
            // lbl_novofuncionario
            // 
            lbl_novofuncionario.AutoSize = true;
            lbl_novofuncionario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_novofuncionario.Location = new Point(105, 17);
            lbl_novofuncionario.Name = "lbl_novofuncionario";
            lbl_novofuncionario.Size = new Size(173, 25);
            lbl_novofuncionario.TabIndex = 85;
            lbl_novofuncionario.Text = "Novo Funcionario";
            // 
            // pictureBox1_novofuncionario
            // 
            pictureBox1_novofuncionario.BackColor = Color.White;
            pictureBox1_novofuncionario.Location = new Point(12, 45);
            pictureBox1_novofuncionario.Name = "pictureBox1_novofuncionario";
            pictureBox1_novofuncionario.Size = new Size(360, 455);
            pictureBox1_novofuncionario.TabIndex = 84;
            pictureBox1_novofuncionario.TabStop = false;
            // 
            // msktxtbox_nfun_cpf
            // 
            msktxtbox_nfun_cpf.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            msktxtbox_nfun_cpf.Location = new Point(27, 187);
            msktxtbox_nfun_cpf.Mask = "000,000,000-00";
            msktxtbox_nfun_cpf.Name = "msktxtbox_nfun_cpf";
            msktxtbox_nfun_cpf.Size = new Size(329, 23);
            msktxtbox_nfun_cpf.TabIndex = 97;
            msktxtbox_nfun_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtbox_nfunc_codigo
            // 
            txtbox_nfunc_codigo.Location = new Point(298, 65);
            txtbox_nfunc_codigo.Name = "txtbox_nfunc_codigo";
            txtbox_nfunc_codigo.ReadOnly = true;
            txtbox_nfunc_codigo.Size = new Size(58, 23);
            txtbox_nfunc_codigo.TabIndex = 98;
            // 
            // lbl_nfunc_codigo
            // 
            lbl_nfunc_codigo.AutoSize = true;
            lbl_nfunc_codigo.BackColor = Color.White;
            lbl_nfunc_codigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nfunc_codigo.ForeColor = SystemColors.ControlDarkDark;
            lbl_nfunc_codigo.Location = new Point(247, 69);
            lbl_nfunc_codigo.Name = "lbl_nfunc_codigo";
            lbl_nfunc_codigo.Size = new Size(45, 15);
            lbl_nfunc_codigo.TabIndex = 99;
            lbl_nfunc_codigo.Text = "Código";
            // 
            // TelaNovoFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(lbl_nfunc_codigo);
            Controls.Add(txtbox_nfunc_codigo);
            Controls.Add(msktxtbox_nfun_cpf);
            Controls.Add(combobox_nfunc_equipe);
            Controls.Add(lbl_nfunc_equipe);
            Controls.Add(txtbox_nfunc_email);
            Controls.Add(btn_nfunc_salvar);
            Controls.Add(btn_nfunc_voltar);
            Controls.Add(txtbox_nfunc_nomecompleto);
            Controls.Add(lbl_nfunc_email);
            Controls.Add(lbl_nfunc_cpf);
            Controls.Add(lbl_nfunc_nomecompleto);
            Controls.Add(lbl_dadosdofuncionario);
            Controls.Add(lbl_novofuncionario);
            Controls.Add(pictureBox1_novofuncionario);
            MaximizeBox = false;
            Name = "TelaNovoFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaNovoFuncionario_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1_novofuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_nfunc_equipe;
        private TextBox msktxtbox_nfunc_cpf;
        private Label lbl_nfunc_email;
        private Label lbl_nfunc_cpf;
        private Label lbl_nfunc_nomecompleto;
        private Label lbl_dadosdofuncionario;
        private PictureBox pictureBox1_novofuncionario;
        public ComboBox combobox_nfunc_equipe;
        public TextBox txtbox_nfunc_email;
        public TextBox txtbox_nfunc_nomecompleto;
        public MaskedTextBox msktxtbox_nfun_cpf;
        public Button btn_nfunc_salvar;
        public Button btn_nfunc_voltar;
        public Label lbl_novofuncionario;
        public TextBox txtbox_nfunc_codigo;
        public Label lbl_nfunc_codigo;
    }
}