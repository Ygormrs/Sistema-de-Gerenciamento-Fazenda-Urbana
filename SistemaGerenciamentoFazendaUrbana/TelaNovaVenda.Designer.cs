namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaNovaVenda
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
            pictureBox2 = new PictureBox();
            lbl_novavenda = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            msktxtbox_nv_cnpj = new MaskedTextBox();
            lbl_nv_cpf_cnpj = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbl_nv_data = new Label();
            lbl_nv_dadosdavenda = new Label();
            combobox_nv_produto = new ComboBox();
            txtbox_nv_quantidade = new TextBox();
            lbl_nv_produto = new Label();
            lbl_nv_quantidade = new Label();
            btn_nv_salvar = new Button();
            btn_nv_voltar = new Button();
            txtbox_nv_codigo = new TextBox();
            lbl_codigo_venda = new Label();
            btn_att_ncompra = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1009, 47);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lbl_novavenda
            // 
            lbl_novavenda.AutoSize = true;
            lbl_novavenda.BackColor = Color.White;
            lbl_novavenda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_novavenda.ForeColor = SystemColors.ControlDarkDark;
            lbl_novavenda.Location = new Point(58, 19);
            lbl_novavenda.Name = "lbl_novavenda";
            lbl_novavenda.Size = new Size(93, 20);
            lbl_novavenda.TabIndex = 18;
            lbl_novavenda.Text = "Nova Venda";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.LogoNexus;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 505);
            pictureBox1.TabIndex = 86;
            pictureBox1.TabStop = false;
            // 
            // msktxtbox_nv_cnpj
            // 
            msktxtbox_nv_cnpj.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            msktxtbox_nv_cnpj.Location = new Point(58, 191);
            msktxtbox_nv_cnpj.Mask = "00,000,000/0000-00";
            msktxtbox_nv_cnpj.Name = "msktxtbox_nv_cnpj";
            msktxtbox_nv_cnpj.Size = new Size(227, 23);
            msktxtbox_nv_cnpj.TabIndex = 87;
            // 
            // lbl_nv_cpf_cnpj
            // 
            lbl_nv_cpf_cnpj.AutoSize = true;
            lbl_nv_cpf_cnpj.BackColor = Color.White;
            lbl_nv_cpf_cnpj.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nv_cpf_cnpj.ForeColor = SystemColors.ControlDarkDark;
            lbl_nv_cpf_cnpj.Location = new Point(58, 173);
            lbl_nv_cpf_cnpj.Name = "lbl_nv_cpf_cnpj";
            lbl_nv_cpf_cnpj.Size = new Size(34, 15);
            lbl_nv_cpf_cnpj.TabIndex = 89;
            lbl_nv_cpf_cnpj.Text = "CNPJ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(696, 263);
            dateTimePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 23);
            dateTimePicker1.TabIndex = 90;
            // 
            // lbl_nv_data
            // 
            lbl_nv_data.AutoSize = true;
            lbl_nv_data.BackColor = Color.White;
            lbl_nv_data.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nv_data.ForeColor = SystemColors.ControlDarkDark;
            lbl_nv_data.Location = new Point(696, 245);
            lbl_nv_data.Name = "lbl_nv_data";
            lbl_nv_data.Size = new Size(118, 15);
            lbl_nv_data.TabIndex = 91;
            lbl_nv_data.Text = "Previsão de entrega";
            // 
            // lbl_nv_dadosdavenda
            // 
            lbl_nv_dadosdavenda.AutoSize = true;
            lbl_nv_dadosdavenda.BackColor = Color.White;
            lbl_nv_dadosdavenda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nv_dadosdavenda.ForeColor = Color.Green;
            lbl_nv_dadosdavenda.Location = new Point(58, 100);
            lbl_nv_dadosdavenda.Name = "lbl_nv_dadosdavenda";
            lbl_nv_dadosdavenda.Size = new Size(133, 21);
            lbl_nv_dadosdavenda.TabIndex = 92;
            lbl_nv_dadosdavenda.Text = "Dados da Venda";
            // 
            // combobox_nv_produto
            // 
            combobox_nv_produto.FormattingEnabled = true;
            combobox_nv_produto.Location = new Point(58, 263);
            combobox_nv_produto.Name = "combobox_nv_produto";
            combobox_nv_produto.Size = new Size(227, 23);
            combobox_nv_produto.TabIndex = 98;
            // 
            // txtbox_nv_quantidade
            // 
            txtbox_nv_quantidade.Location = new Point(382, 263);
            txtbox_nv_quantidade.Name = "txtbox_nv_quantidade";
            txtbox_nv_quantidade.Size = new Size(227, 23);
            txtbox_nv_quantidade.TabIndex = 99;
            // 
            // lbl_nv_produto
            // 
            lbl_nv_produto.AutoSize = true;
            lbl_nv_produto.BackColor = Color.White;
            lbl_nv_produto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nv_produto.ForeColor = SystemColors.ControlDarkDark;
            lbl_nv_produto.Location = new Point(58, 245);
            lbl_nv_produto.Name = "lbl_nv_produto";
            lbl_nv_produto.Size = new Size(52, 15);
            lbl_nv_produto.TabIndex = 100;
            lbl_nv_produto.Text = "Produto";
            // 
            // lbl_nv_quantidade
            // 
            lbl_nv_quantidade.AutoSize = true;
            lbl_nv_quantidade.BackColor = Color.White;
            lbl_nv_quantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nv_quantidade.ForeColor = SystemColors.ControlDarkDark;
            lbl_nv_quantidade.Location = new Point(382, 245);
            lbl_nv_quantidade.Name = "lbl_nv_quantidade";
            lbl_nv_quantidade.Size = new Size(71, 15);
            lbl_nv_quantidade.TabIndex = 101;
            lbl_nv_quantidade.Text = "Quantidade";
            // 
            // btn_nv_salvar
            // 
            btn_nv_salvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nv_salvar.Location = new Point(863, 620);
            btn_nv_salvar.Name = "btn_nv_salvar";
            btn_nv_salvar.Size = new Size(75, 23);
            btn_nv_salvar.TabIndex = 103;
            btn_nv_salvar.Text = "Salvar";
            btn_nv_salvar.UseVisualStyleBackColor = true;
            btn_nv_salvar.Click += btn_nv_salvar_Click;
            // 
            // btn_nv_voltar
            // 
            btn_nv_voltar.BackColor = Color.Red;
            btn_nv_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nv_voltar.ForeColor = SystemColors.Control;
            btn_nv_voltar.Location = new Point(58, 620);
            btn_nv_voltar.Name = "btn_nv_voltar";
            btn_nv_voltar.Size = new Size(75, 23);
            btn_nv_voltar.TabIndex = 102;
            btn_nv_voltar.Text = "Voltar";
            btn_nv_voltar.UseVisualStyleBackColor = false;
            btn_nv_voltar.Click += btn_nv_voltar_Click;
            // 
            // txtbox_nv_codigo
            // 
            txtbox_nv_codigo.Location = new Point(863, 102);
            txtbox_nv_codigo.Name = "txtbox_nv_codigo";
            txtbox_nv_codigo.ReadOnly = true;
            txtbox_nv_codigo.Size = new Size(75, 23);
            txtbox_nv_codigo.TabIndex = 104;
            // 
            // lbl_codigo_venda
            // 
            lbl_codigo_venda.AutoSize = true;
            lbl_codigo_venda.BackColor = Color.White;
            lbl_codigo_venda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_codigo_venda.ForeColor = SystemColors.ControlDarkDark;
            lbl_codigo_venda.Location = new Point(809, 106);
            lbl_codigo_venda.Name = "lbl_codigo_venda";
            lbl_codigo_venda.Size = new Size(45, 15);
            lbl_codigo_venda.TabIndex = 105;
            lbl_codigo_venda.Text = "Código";
            // 
            // btn_att_ncompra
            // 
            btn_att_ncompra.BackColor = Color.YellowGreen;
            btn_att_ncompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_att_ncompra.Location = new Point(463, 620);
            btn_att_ncompra.Name = "btn_att_ncompra";
            btn_att_ncompra.Size = new Size(75, 23);
            btn_att_ncompra.TabIndex = 158;
            btn_att_ncompra.Text = "Atualizar";
            btn_att_ncompra.UseVisualStyleBackColor = false;
            btn_att_ncompra.Click += btn_att_ncompra_Click;
            // 
            // TelaNovaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(btn_att_ncompra);
            Controls.Add(lbl_codigo_venda);
            Controls.Add(txtbox_nv_codigo);
            Controls.Add(btn_nv_salvar);
            Controls.Add(btn_nv_voltar);
            Controls.Add(lbl_nv_quantidade);
            Controls.Add(lbl_nv_produto);
            Controls.Add(txtbox_nv_quantidade);
            Controls.Add(combobox_nv_produto);
            Controls.Add(lbl_nv_dadosdavenda);
            Controls.Add(lbl_nv_data);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_nv_cpf_cnpj);
            Controls.Add(msktxtbox_nv_cnpj);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(lbl_novavenda);
            Controls.Add(pictureBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaNovaVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label lbl_nv_cpf_cnpj;
        private Label lbl_nv_data;
        private Label lbl_nv_dadosdavenda;
        private Label lbl_nv_produto;
        private Label lbl_nv_quantidade;
        private Label lbl_codigo_venda;
        public Label lbl_novavenda;
        public MaskedTextBox msktxtbox_nv_cnpj;
        public ComboBox combobox_nv_produto;
        public Button btn_nv_salvar;
        public Button btn_nv_voltar;
        public TextBox txtbox_nv_codigo;
        public DateTimePicker dateTimePicker1;
        public TextBox txtbox_nv_quantidade;
        public Button btn_att_ncompra;
    }
}