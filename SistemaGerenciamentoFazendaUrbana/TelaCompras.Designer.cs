namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaCompras
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
            lbl_clientes = new Label();
            pictureBox1 = new PictureBox();
            lbl_cod_compra = new Label();
            txtbox_cod_compra = new TextBox();
            lbl_status_compra = new Label();
            combobox_status_compra = new ComboBox();
            btn_solicitarcompra = new Button();
            btn_consultarcompra = new Button();
            dataGridView1 = new DataGridView();
            btn_compras_voltar = new Button();
            btn_editar_compra = new Button();
            btn_pesquisar = new Button();
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
            pictureBox2.TabIndex = 5;
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
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // lbl_clientes
            // 
            lbl_clientes.AutoSize = true;
            lbl_clientes.BackColor = Color.White;
            lbl_clientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_clientes.ForeColor = SystemColors.ControlDarkDark;
            lbl_clientes.Location = new Point(71, 19);
            lbl_clientes.Name = "lbl_clientes";
            lbl_clientes.Size = new Size(71, 20);
            lbl_clientes.TabIndex = 16;
            lbl_clientes.Text = "Compras";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 118);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lbl_cod_compra
            // 
            lbl_cod_compra.AutoSize = true;
            lbl_cod_compra.BackColor = Color.White;
            lbl_cod_compra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cod_compra.ForeColor = SystemColors.ControlDarkDark;
            lbl_cod_compra.Location = new Point(35, 76);
            lbl_cod_compra.Name = "lbl_cod_compra";
            lbl_cod_compra.Size = new Size(123, 17);
            lbl_cod_compra.TabIndex = 18;
            lbl_cod_compra.Text = "Código da Compra";
            // 
            // txtbox_cod_compra
            // 
            txtbox_cod_compra.Location = new Point(35, 96);
            txtbox_cod_compra.Name = "txtbox_cod_compra";
            txtbox_cod_compra.Size = new Size(159, 23);
            txtbox_cod_compra.TabIndex = 25;
            // 
            // lbl_status_compra
            // 
            lbl_status_compra.AutoSize = true;
            lbl_status_compra.BackColor = Color.White;
            lbl_status_compra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_status_compra.ForeColor = SystemColors.ControlDarkDark;
            lbl_status_compra.Location = new Point(274, 76);
            lbl_status_compra.Name = "lbl_status_compra";
            lbl_status_compra.Size = new Size(46, 17);
            lbl_status_compra.TabIndex = 26;
            lbl_status_compra.Text = "Status";
            // 
            // combobox_status_compra
            // 
            combobox_status_compra.FormattingEnabled = true;
            combobox_status_compra.Location = new Point(274, 96);
            combobox_status_compra.Name = "combobox_status_compra";
            combobox_status_compra.Size = new Size(187, 23);
            combobox_status_compra.TabIndex = 27;
            // 
            // btn_solicitarcompra
            // 
            btn_solicitarcompra.BackColor = Color.Green;
            btn_solicitarcompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_solicitarcompra.ForeColor = Color.White;
            btn_solicitarcompra.Location = new Point(35, 141);
            btn_solicitarcompra.Name = "btn_solicitarcompra";
            btn_solicitarcompra.Size = new Size(144, 23);
            btn_solicitarcompra.TabIndex = 28;
            btn_solicitarcompra.Text = "Solicitar Compra";
            btn_solicitarcompra.UseVisualStyleBackColor = false;
            btn_solicitarcompra.Click += btn_solicitarcompra_Click;
            // 
            // btn_consultarcompra
            // 
            btn_consultarcompra.BackColor = Color.Green;
            btn_consultarcompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultarcompra.ForeColor = Color.White;
            btn_consultarcompra.Location = new Point(405, 141);
            btn_consultarcompra.Name = "btn_consultarcompra";
            btn_consultarcompra.Size = new Size(144, 23);
            btn_consultarcompra.TabIndex = 29;
            btn_consultarcompra.Text = "Consultar Compra";
            btn_consultarcompra.UseVisualStyleBackColor = false;
            btn_consultarcompra.Click += btn_consultarcompra_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(984, 425);
            dataGridView1.TabIndex = 30;
            // 
            // btn_compras_voltar
            // 
            btn_compras_voltar.BackColor = Color.Red;
            btn_compras_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_compras_voltar.ForeColor = SystemColors.Control;
            btn_compras_voltar.Location = new Point(35, 635);
            btn_compras_voltar.Name = "btn_compras_voltar";
            btn_compras_voltar.Size = new Size(75, 23);
            btn_compras_voltar.TabIndex = 80;
            btn_compras_voltar.Text = "Voltar";
            btn_compras_voltar.UseVisualStyleBackColor = false;
            btn_compras_voltar.Click += btn_compras_voltar_Click;
            // 
            // btn_editar_compra
            // 
            btn_editar_compra.BackColor = Color.Green;
            btn_editar_compra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar_compra.ForeColor = Color.White;
            btn_editar_compra.Location = new Point(223, 141);
            btn_editar_compra.Name = "btn_editar_compra";
            btn_editar_compra.Size = new Size(144, 23);
            btn_editar_compra.TabIndex = 81;
            btn_editar_compra.Text = "Editar Compra";
            btn_editar_compra.UseVisualStyleBackColor = false;
            btn_editar_compra.Click += btn_editar_compra_Click;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(854, 96);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(88, 24);
            btn_pesquisar.TabIndex = 85;
            btn_pesquisar.Text = "Pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // TelaCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(btn_pesquisar);
            Controls.Add(btn_editar_compra);
            Controls.Add(btn_compras_voltar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_consultarcompra);
            Controls.Add(btn_solicitarcompra);
            Controls.Add(combobox_status_compra);
            Controls.Add(lbl_status_compra);
            Controls.Add(txtbox_cod_compra);
            Controls.Add(lbl_cod_compra);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_clientes);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            MaximizeBox = false;
            Name = "TelaCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaCompras_FormClosing;
            Load += TelaCompras_Load;
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
        private Label lbl_clientes;
        private PictureBox pictureBox1;
        private Label lbl_cod_compra;
        private TextBox txtbox_cod_compra;
        private Label lbl_status_compra;
        private ComboBox combobox_status_compra;
        private Button btn_solicitarcompra;
        private Button btn_consultarcompra;
        private DataGridView dataGridView1;
        private Button btn_compras_voltar;
        private Button btn_editar_compra;
        private Button btn_pesquisar;
    }
}