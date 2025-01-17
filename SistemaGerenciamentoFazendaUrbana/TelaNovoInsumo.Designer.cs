namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaNovoInsumo
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
            txtbox_ni_quantidadedisponivel = new TextBox();
            btn_ni_salvar = new Button();
            btn_ni_voltar = new Button();
            txtbox_ni_nomeinsumo = new TextBox();
            lbl_ni_quantidade = new Label();
            lbl_ni_tipoinsumo = new Label();
            lbl_ni_nomeinsumo = new Label();
            lbl_dadosdoinsumo = new Label();
            lbl_novoinsumo = new Label();
            pictureBox1_novoinsumo = new PictureBox();
            combobox_ni_tipoinsumo = new ComboBox();
            lbl_ni_cnpj_fornecedor = new Label();
            msktxtbox_ni_cnpj_fornecedor = new MaskedTextBox();
            txtbox_ni_codigo = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_novoinsumo).BeginInit();
            SuspendLayout();
            // 
            // txtbox_ni_quantidadedisponivel
            // 
            txtbox_ni_quantidadedisponivel.Location = new Point(27, 259);
            txtbox_ni_quantidadedisponivel.Name = "txtbox_ni_quantidadedisponivel";
            txtbox_ni_quantidadedisponivel.Size = new Size(329, 23);
            txtbox_ni_quantidadedisponivel.TabIndex = 2;
            // 
            // btn_ni_salvar
            // 
            btn_ni_salvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ni_salvar.Location = new Point(281, 520);
            btn_ni_salvar.Name = "btn_ni_salvar";
            btn_ni_salvar.Size = new Size(75, 23);
            btn_ni_salvar.TabIndex = 5;
            btn_ni_salvar.Text = "Salvar";
            btn_ni_salvar.UseVisualStyleBackColor = true;
            btn_ni_salvar.Click += btn_ni_salvar_Click;
            // 
            // btn_ni_voltar
            // 
            btn_ni_voltar.BackColor = Color.Red;
            btn_ni_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ni_voltar.ForeColor = SystemColors.Control;
            btn_ni_voltar.Location = new Point(27, 520);
            btn_ni_voltar.Name = "btn_ni_voltar";
            btn_ni_voltar.Size = new Size(75, 23);
            btn_ni_voltar.TabIndex = 4;
            btn_ni_voltar.Text = "Voltar";
            btn_ni_voltar.UseVisualStyleBackColor = false;
            btn_ni_voltar.Click += btn_ni_voltar_Click;
            // 
            // txtbox_ni_nomeinsumo
            // 
            txtbox_ni_nomeinsumo.Location = new Point(27, 122);
            txtbox_ni_nomeinsumo.Name = "txtbox_ni_nomeinsumo";
            txtbox_ni_nomeinsumo.Size = new Size(329, 23);
            txtbox_ni_nomeinsumo.TabIndex = 0;
            // 
            // lbl_ni_quantidade
            // 
            lbl_ni_quantidade.AutoSize = true;
            lbl_ni_quantidade.BackColor = Color.White;
            lbl_ni_quantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ni_quantidade.ForeColor = SystemColors.ControlDarkDark;
            lbl_ni_quantidade.Location = new Point(27, 241);
            lbl_ni_quantidade.Name = "lbl_ni_quantidade";
            lbl_ni_quantidade.Size = new Size(71, 15);
            lbl_ni_quantidade.TabIndex = 102;
            lbl_ni_quantidade.Text = "Quantidade";
            // 
            // lbl_ni_tipoinsumo
            // 
            lbl_ni_tipoinsumo.AutoSize = true;
            lbl_ni_tipoinsumo.BackColor = Color.White;
            lbl_ni_tipoinsumo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ni_tipoinsumo.ForeColor = SystemColors.ControlDarkDark;
            lbl_ni_tipoinsumo.Location = new Point(27, 169);
            lbl_ni_tipoinsumo.Name = "lbl_ni_tipoinsumo";
            lbl_ni_tipoinsumo.Size = new Size(92, 15);
            lbl_ni_tipoinsumo.TabIndex = 101;
            lbl_ni_tipoinsumo.Text = "Tipo do Insumo";
            // 
            // lbl_ni_nomeinsumo
            // 
            lbl_ni_nomeinsumo.AutoSize = true;
            lbl_ni_nomeinsumo.BackColor = Color.White;
            lbl_ni_nomeinsumo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ni_nomeinsumo.ForeColor = SystemColors.ControlDarkDark;
            lbl_ni_nomeinsumo.Location = new Point(27, 104);
            lbl_ni_nomeinsumo.Name = "lbl_ni_nomeinsumo";
            lbl_ni_nomeinsumo.Size = new Size(102, 15);
            lbl_ni_nomeinsumo.TabIndex = 100;
            lbl_ni_nomeinsumo.Text = "Nome do Insumo";
            // 
            // lbl_dadosdoinsumo
            // 
            lbl_dadosdoinsumo.AutoSize = true;
            lbl_dadosdoinsumo.BackColor = Color.White;
            lbl_dadosdoinsumo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dadosdoinsumo.ForeColor = Color.Green;
            lbl_dadosdoinsumo.Location = new Point(27, 63);
            lbl_dadosdoinsumo.Name = "lbl_dadosdoinsumo";
            lbl_dadosdoinsumo.Size = new Size(143, 21);
            lbl_dadosdoinsumo.TabIndex = 99;
            lbl_dadosdoinsumo.Text = "Dados do Insumo";
            // 
            // lbl_novoinsumo
            // 
            lbl_novoinsumo.AutoSize = true;
            lbl_novoinsumo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_novoinsumo.Location = new Point(128, 17);
            lbl_novoinsumo.Name = "lbl_novoinsumo";
            lbl_novoinsumo.Size = new Size(133, 25);
            lbl_novoinsumo.TabIndex = 98;
            lbl_novoinsumo.Text = "Novo Insumo";
            // 
            // pictureBox1_novoinsumo
            // 
            pictureBox1_novoinsumo.BackColor = Color.White;
            pictureBox1_novoinsumo.Location = new Point(12, 45);
            pictureBox1_novoinsumo.Name = "pictureBox1_novoinsumo";
            pictureBox1_novoinsumo.Size = new Size(360, 455);
            pictureBox1_novoinsumo.TabIndex = 97;
            pictureBox1_novoinsumo.TabStop = false;
            // 
            // combobox_ni_tipoinsumo
            // 
            combobox_ni_tipoinsumo.FormattingEnabled = true;
            combobox_ni_tipoinsumo.Items.AddRange(new object[] { "Adubo", "Semente", "Muda" });
            combobox_ni_tipoinsumo.Location = new Point(27, 187);
            combobox_ni_tipoinsumo.Name = "combobox_ni_tipoinsumo";
            combobox_ni_tipoinsumo.Size = new Size(329, 23);
            combobox_ni_tipoinsumo.TabIndex = 1;
            // 
            // lbl_ni_cnpj_fornecedor
            // 
            lbl_ni_cnpj_fornecedor.AutoSize = true;
            lbl_ni_cnpj_fornecedor.BackColor = Color.White;
            lbl_ni_cnpj_fornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ni_cnpj_fornecedor.ForeColor = SystemColors.ControlDarkDark;
            lbl_ni_cnpj_fornecedor.Location = new Point(27, 315);
            lbl_ni_cnpj_fornecedor.Name = "lbl_ni_cnpj_fornecedor";
            lbl_ni_cnpj_fornecedor.Size = new Size(101, 15);
            lbl_ni_cnpj_fornecedor.TabIndex = 112;
            lbl_ni_cnpj_fornecedor.Text = "CNPJ Fornecedor";
            // 
            // msktxtbox_ni_cnpj_fornecedor
            // 
            msktxtbox_ni_cnpj_fornecedor.Location = new Point(27, 333);
            msktxtbox_ni_cnpj_fornecedor.Mask = "000,000,000-00";
            msktxtbox_ni_cnpj_fornecedor.Name = "msktxtbox_ni_cnpj_fornecedor";
            msktxtbox_ni_cnpj_fornecedor.Size = new Size(329, 23);
            msktxtbox_ni_cnpj_fornecedor.TabIndex = 3;
            msktxtbox_ni_cnpj_fornecedor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtbox_ni_codigo
            // 
            txtbox_ni_codigo.Location = new Point(274, 65);
            txtbox_ni_codigo.Name = "txtbox_ni_codigo";
            txtbox_ni_codigo.ReadOnly = true;
            txtbox_ni_codigo.Size = new Size(82, 23);
            txtbox_ni_codigo.TabIndex = 113;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(223, 69);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 114;
            label1.Text = "Código";
            // 
            // TelaNovoInsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(label1);
            Controls.Add(txtbox_ni_codigo);
            Controls.Add(msktxtbox_ni_cnpj_fornecedor);
            Controls.Add(lbl_ni_cnpj_fornecedor);
            Controls.Add(combobox_ni_tipoinsumo);
            Controls.Add(txtbox_ni_quantidadedisponivel);
            Controls.Add(btn_ni_salvar);
            Controls.Add(btn_ni_voltar);
            Controls.Add(txtbox_ni_nomeinsumo);
            Controls.Add(lbl_ni_quantidade);
            Controls.Add(lbl_ni_tipoinsumo);
            Controls.Add(lbl_ni_nomeinsumo);
            Controls.Add(lbl_dadosdoinsumo);
            Controls.Add(lbl_novoinsumo);
            Controls.Add(pictureBox1_novoinsumo);
            MaximizeBox = false;
            Name = "TelaNovoInsumo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaNovoInsumo_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1_novoinsumo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_ni_quantidade;
        private Label lbl_ni_tipoinsumo;
        private Label lbl_ni_nomeinsumo;
        private Label lbl_dadosdoinsumo;
        private PictureBox pictureBox1_novoinsumo;
        private Label lbl_ni_cnpj_fornecedor;
        public TextBox txtbox_ni_quantidadedisponivel;
        public TextBox txtbox_ni_nomeinsumo;
        public ComboBox combobox_ni_tipoinsumo;
        public MaskedTextBox msktxtbox_ni_cnpj_fornecedor;
        public Button btn_ni_salvar;
        public Button btn_ni_voltar;
        public TextBox txtbox_ni_codigo;
        private Label label1;
        public Label lbl_novoinsumo;
    }
}