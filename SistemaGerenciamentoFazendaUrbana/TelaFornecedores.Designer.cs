namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaFornecedores
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
            pictureBox3 = new PictureBox();
            lbl_fornecedores = new Label();
            pictureBox1 = new PictureBox();
            lbl_cod_fornecedor = new Label();
            lbl_nome_fornecedor = new Label();
            lbl_status_fornecedor = new Label();
            txtbox_cnpj_fornecedor = new TextBox();
            txtbox_nome_fornecedor = new TextBox();
            combobox_status_fornecedor = new ComboBox();
            btn_add_fornecedor = new Button();
            button1 = new Button();
            btn_fornecedor_consulta = new Button();
            dataGridView1 = new DataGridView();
            btn_fornecedores_voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1009, 47);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.LogoNexus;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // lbl_fornecedores
            // 
            lbl_fornecedores.AutoSize = true;
            lbl_fornecedores.BackColor = Color.White;
            lbl_fornecedores.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_fornecedores.ForeColor = SystemColors.ControlDarkDark;
            lbl_fornecedores.Location = new Point(67, 19);
            lbl_fornecedores.Name = "lbl_fornecedores";
            lbl_fornecedores.Size = new Size(103, 20);
            lbl_fornecedores.TabIndex = 14;
            lbl_fornecedores.Text = "Fornecedores";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 118);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lbl_cod_fornecedor
            // 
            lbl_cod_fornecedor.AutoSize = true;
            lbl_cod_fornecedor.BackColor = Color.White;
            lbl_cod_fornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cod_fornecedor.ForeColor = SystemColors.ControlDarkDark;
            lbl_cod_fornecedor.Location = new Point(32, 83);
            lbl_cod_fornecedor.Name = "lbl_cod_fornecedor";
            lbl_cod_fornecedor.Size = new Size(132, 17);
            lbl_cod_fornecedor.TabIndex = 16;
            lbl_cod_fornecedor.Text = "CNPJ do Fornecedor";
            // 
            // lbl_nome_fornecedor
            // 
            lbl_nome_fornecedor.AutoSize = true;
            lbl_nome_fornecedor.BackColor = Color.White;
            lbl_nome_fornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome_fornecedor.ForeColor = SystemColors.ControlDarkDark;
            lbl_nome_fornecedor.Location = new Point(232, 83);
            lbl_nome_fornecedor.Name = "lbl_nome_fornecedor";
            lbl_nome_fornecedor.Size = new Size(138, 17);
            lbl_nome_fornecedor.TabIndex = 17;
            lbl_nome_fornecedor.Text = "Nome do Fornecedor";
            // 
            // lbl_status_fornecedor
            // 
            lbl_status_fornecedor.AutoSize = true;
            lbl_status_fornecedor.BackColor = Color.White;
            lbl_status_fornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_status_fornecedor.ForeColor = SystemColors.ControlDarkDark;
            lbl_status_fornecedor.Location = new Point(428, 83);
            lbl_status_fornecedor.Name = "lbl_status_fornecedor";
            lbl_status_fornecedor.Size = new Size(46, 17);
            lbl_status_fornecedor.TabIndex = 18;
            lbl_status_fornecedor.Text = "Status";
            // 
            // txtbox_cnpj_fornecedor
            // 
            txtbox_cnpj_fornecedor.Location = new Point(32, 103);
            txtbox_cnpj_fornecedor.Name = "txtbox_cnpj_fornecedor";
            txtbox_cnpj_fornecedor.Size = new Size(159, 23);
            txtbox_cnpj_fornecedor.TabIndex = 23;
            // 
            // txtbox_nome_fornecedor
            // 
            txtbox_nome_fornecedor.Location = new Point(232, 103);
            txtbox_nome_fornecedor.Name = "txtbox_nome_fornecedor";
            txtbox_nome_fornecedor.Size = new Size(159, 23);
            txtbox_nome_fornecedor.TabIndex = 24;
            // 
            // combobox_status_fornecedor
            // 
            combobox_status_fornecedor.FormattingEnabled = true;
            combobox_status_fornecedor.Location = new Point(428, 103);
            combobox_status_fornecedor.Name = "combobox_status_fornecedor";
            combobox_status_fornecedor.Size = new Size(187, 23);
            combobox_status_fornecedor.TabIndex = 25;
            // 
            // btn_add_fornecedor
            // 
            btn_add_fornecedor.BackColor = Color.Green;
            btn_add_fornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_fornecedor.ForeColor = Color.White;
            btn_add_fornecedor.Location = new Point(32, 148);
            btn_add_fornecedor.Name = "btn_add_fornecedor";
            btn_add_fornecedor.Size = new Size(144, 23);
            btn_add_fornecedor.TabIndex = 26;
            btn_add_fornecedor.Text = "Adicionar Fornecedor";
            btn_add_fornecedor.UseVisualStyleBackColor = false;
            btn_add_fornecedor.Click += btn_add_fornecedor_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(428, 148);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 27;
            button1.Text = "Editar Fornecedor";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_fornecedor_consulta
            // 
            btn_fornecedor_consulta.BackColor = Color.Green;
            btn_fornecedor_consulta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_fornecedor_consulta.ForeColor = Color.White;
            btn_fornecedor_consulta.Location = new Point(828, 148);
            btn_fornecedor_consulta.Name = "btn_fornecedor_consulta";
            btn_fornecedor_consulta.Size = new Size(144, 23);
            btn_fornecedor_consulta.TabIndex = 28;
            btn_fornecedor_consulta.Text = "Consultar Fornecedor";
            btn_fornecedor_consulta.UseVisualStyleBackColor = false;
            btn_fornecedor_consulta.Click += btn_fornecedor_consulta_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(984, 419);
            dataGridView1.TabIndex = 29;
            // 
            // btn_fornecedores_voltar
            // 
            btn_fornecedores_voltar.BackColor = Color.Red;
            btn_fornecedores_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_fornecedores_voltar.ForeColor = SystemColors.Control;
            btn_fornecedores_voltar.Location = new Point(32, 636);
            btn_fornecedores_voltar.Name = "btn_fornecedores_voltar";
            btn_fornecedores_voltar.Size = new Size(75, 23);
            btn_fornecedores_voltar.TabIndex = 46;
            btn_fornecedores_voltar.Text = "Voltar";
            btn_fornecedores_voltar.UseVisualStyleBackColor = false;
            btn_fornecedores_voltar.Click += btn_fornecedores_voltar_Click;
            // 
            // TelaFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1008, 681);
            Controls.Add(btn_fornecedores_voltar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_fornecedor_consulta);
            Controls.Add(button1);
            Controls.Add(btn_add_fornecedor);
            Controls.Add(combobox_status_fornecedor);
            Controls.Add(txtbox_nome_fornecedor);
            Controls.Add(txtbox_cnpj_fornecedor);
            Controls.Add(lbl_status_fornecedor);
            Controls.Add(lbl_nome_fornecedor);
            Controls.Add(lbl_cod_fornecedor);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_fornecedores);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "TelaFornecedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaFornecedores_FormClosing;
            Load += TelaFornecedores_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbl_fornecedores;
        private PictureBox pictureBox1;
        private Label lbl_cod_fornecedor;
        private Label lbl_nome_fornecedor;
        private Label lbl_status_fornecedor;
        private TextBox txtbox_cnpj_fornecedor;
        private TextBox txtbox_nome_fornecedor;
        private ComboBox combobox_status_fornecedor;
        private Button btn_add_fornecedor;
        private Button button1;
        private Button btn_fornecedor_consulta;
        private DataGridView dataGridView1;
        private Button btn_fornecedores_voltar;
    }
}