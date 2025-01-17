namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaNovaCompra
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
            lbl_novacompra = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_nc_cnpj_fornecedor = new Label();
            label1 = new Label();
            btn_novacompra_voltar = new Button();
            btn_novacompra_salvar = new Button();
            txtbox_nc_produto = new TextBox();
            lbl_nc_produto = new Label();
            txtbox_nc_quantidade = new TextBox();
            lbl_nc_quantidade = new Label();
            msktxtbox_nc_cnpj_forn = new MaskedTextBox();
            txtbox_nc_solicitante = new TextBox();
            txtbox_codigo_compra = new TextBox();
            lbl_dadosdacompra = new Label();
            lbl_codigo_compra = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(-2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1009, 47);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lbl_novacompra
            // 
            lbl_novacompra.AutoSize = true;
            lbl_novacompra.BackColor = Color.White;
            lbl_novacompra.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_novacompra.ForeColor = SystemColors.ControlDarkDark;
            lbl_novacompra.Location = new Point(63, 19);
            lbl_novacompra.Name = "lbl_novacompra";
            lbl_novacompra.Size = new Size(105, 20);
            lbl_novacompra.TabIndex = 17;
            lbl_novacompra.Text = "Nova Compra";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.LogoNexus;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 527);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // lbl_nc_cnpj_fornecedor
            // 
            lbl_nc_cnpj_fornecedor.AutoSize = true;
            lbl_nc_cnpj_fornecedor.BackColor = Color.White;
            lbl_nc_cnpj_fornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_cnpj_fornecedor.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_cnpj_fornecedor.Location = new Point(63, 161);
            lbl_nc_cnpj_fornecedor.Name = "lbl_nc_cnpj_fornecedor";
            lbl_nc_cnpj_fornecedor.Size = new Size(118, 15);
            lbl_nc_cnpj_fornecedor.TabIndex = 50;
            lbl_nc_cnpj_fornecedor.Text = "CNPJ do Fornecedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(625, 161);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 52;
            label1.Text = "Solicitante";
            // 
            // btn_novacompra_voltar
            // 
            btn_novacompra_voltar.BackColor = Color.Red;
            btn_novacompra_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_novacompra_voltar.ForeColor = SystemColors.Control;
            btn_novacompra_voltar.Location = new Point(63, 627);
            btn_novacompra_voltar.Name = "btn_novacompra_voltar";
            btn_novacompra_voltar.Size = new Size(75, 23);
            btn_novacompra_voltar.TabIndex = 81;
            btn_novacompra_voltar.Text = "Voltar";
            btn_novacompra_voltar.UseVisualStyleBackColor = false;
            btn_novacompra_voltar.Click += btn_novacompra_voltar_Click;
            // 
            // btn_novacompra_salvar
            // 
            btn_novacompra_salvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_novacompra_salvar.Location = new Point(859, 627);
            btn_novacompra_salvar.Name = "btn_novacompra_salvar";
            btn_novacompra_salvar.Size = new Size(75, 23);
            btn_novacompra_salvar.TabIndex = 82;
            btn_novacompra_salvar.Text = "Salvar";
            btn_novacompra_salvar.UseVisualStyleBackColor = true;
            btn_novacompra_salvar.Click += btn_novacompra_salvar_Click;
            // 
            // txtbox_nc_produto
            // 
            txtbox_nc_produto.Location = new Point(63, 285);
            txtbox_nc_produto.Name = "txtbox_nc_produto";
            txtbox_nc_produto.Size = new Size(309, 23);
            txtbox_nc_produto.TabIndex = 96;
            // 
            // lbl_nc_produto
            // 
            lbl_nc_produto.AutoSize = true;
            lbl_nc_produto.BackColor = Color.White;
            lbl_nc_produto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_produto.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_produto.Location = new Point(63, 267);
            lbl_nc_produto.Name = "lbl_nc_produto";
            lbl_nc_produto.Size = new Size(52, 15);
            lbl_nc_produto.TabIndex = 97;
            lbl_nc_produto.Text = "Produto";
            // 
            // txtbox_nc_quantidade
            // 
            txtbox_nc_quantidade.Location = new Point(625, 285);
            txtbox_nc_quantidade.Name = "txtbox_nc_quantidade";
            txtbox_nc_quantidade.Size = new Size(309, 23);
            txtbox_nc_quantidade.TabIndex = 98;
            // 
            // lbl_nc_quantidade
            // 
            lbl_nc_quantidade.AutoSize = true;
            lbl_nc_quantidade.BackColor = Color.White;
            lbl_nc_quantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_quantidade.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_quantidade.Location = new Point(625, 267);
            lbl_nc_quantidade.Name = "lbl_nc_quantidade";
            lbl_nc_quantidade.Size = new Size(71, 15);
            lbl_nc_quantidade.TabIndex = 99;
            lbl_nc_quantidade.Text = "Quantidade";
            // 
            // msktxtbox_nc_cnpj_forn
            // 
            msktxtbox_nc_cnpj_forn.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            msktxtbox_nc_cnpj_forn.Location = new Point(63, 179);
            msktxtbox_nc_cnpj_forn.Mask = "00,000,000/0000-00";
            msktxtbox_nc_cnpj_forn.Name = "msktxtbox_nc_cnpj_forn";
            msktxtbox_nc_cnpj_forn.Size = new Size(309, 23);
            msktxtbox_nc_cnpj_forn.TabIndex = 101;
            msktxtbox_nc_cnpj_forn.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtbox_nc_solicitante
            // 
            txtbox_nc_solicitante.Location = new Point(625, 179);
            txtbox_nc_solicitante.Name = "txtbox_nc_solicitante";
            txtbox_nc_solicitante.Size = new Size(309, 23);
            txtbox_nc_solicitante.TabIndex = 102;
            // 
            // txtbox_codigo_compra
            // 
            txtbox_codigo_compra.Location = new Point(859, 97);
            txtbox_codigo_compra.Name = "txtbox_codigo_compra";
            txtbox_codigo_compra.ReadOnly = true;
            txtbox_codigo_compra.Size = new Size(75, 23);
            txtbox_codigo_compra.TabIndex = 103;
            // 
            // lbl_dadosdacompra
            // 
            lbl_dadosdacompra.AutoSize = true;
            lbl_dadosdacompra.BackColor = Color.White;
            lbl_dadosdacompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dadosdacompra.ForeColor = Color.Green;
            lbl_dadosdacompra.Location = new Point(63, 95);
            lbl_dadosdacompra.Name = "lbl_dadosdacompra";
            lbl_dadosdacompra.Size = new Size(145, 21);
            lbl_dadosdacompra.TabIndex = 104;
            lbl_dadosdacompra.Text = "Dados da Compra";
            // 
            // lbl_codigo_compra
            // 
            lbl_codigo_compra.AutoSize = true;
            lbl_codigo_compra.BackColor = Color.White;
            lbl_codigo_compra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_codigo_compra.ForeColor = SystemColors.ControlDarkDark;
            lbl_codigo_compra.Location = new Point(808, 101);
            lbl_codigo_compra.Name = "lbl_codigo_compra";
            lbl_codigo_compra.Size = new Size(45, 15);
            lbl_codigo_compra.TabIndex = 105;
            lbl_codigo_compra.Text = "Código";
            // 
            // TelaNovaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(lbl_codigo_compra);
            Controls.Add(lbl_dadosdacompra);
            Controls.Add(txtbox_codigo_compra);
            Controls.Add(txtbox_nc_solicitante);
            Controls.Add(msktxtbox_nc_cnpj_forn);
            Controls.Add(lbl_nc_quantidade);
            Controls.Add(txtbox_nc_quantidade);
            Controls.Add(lbl_nc_produto);
            Controls.Add(txtbox_nc_produto);
            Controls.Add(btn_novacompra_salvar);
            Controls.Add(btn_novacompra_voltar);
            Controls.Add(label1);
            Controls.Add(lbl_nc_cnpj_fornecedor);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(lbl_novacompra);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaNovaCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaNovaCompra_FormClosing;
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
        private Label lbl_nc_cnpj_fornecedor;
        private Label label1;
        private Label lbl_nc_produto;
        private Label lbl_nc_quantidade;
        public Button btn_novacompra_voltar;
        public Button btn_novacompra_salvar;
        public TextBox txtbox_nc_produto;
        public TextBox txtbox_nc_quantidade;
        public MaskedTextBox msktxtbox_nc_cnpj_forn;
        public TextBox txtbox_nc_solicitante;
        public TextBox txtbox_codigo_compra;
        private Label lbl_dadosdacompra;
        private Label lbl_codigo_compra;
        public Label lbl_novacompra;
    }
}