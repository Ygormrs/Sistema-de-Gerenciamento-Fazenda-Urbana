namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaInsumos
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
            lbl_insumos = new Label();
            pictureBox1 = new PictureBox();
            lbl_cod_insumo = new Label();
            lbl_nome_insumo = new Label();
            lbl_status_insumo = new Label();
            txtbox_cod_insumo = new TextBox();
            txtbox_nome_insumo = new TextBox();
            combobox_status_insumo = new ComboBox();
            btn_add_insumo = new Button();
            btn_consultar_insumo = new Button();
            dataGridView1 = new DataGridView();
            btn_insumos_voltar = new Button();
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
            pictureBox2.TabIndex = 3;
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
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // lbl_insumos
            // 
            lbl_insumos.AutoSize = true;
            lbl_insumos.BackColor = Color.White;
            lbl_insumos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_insumos.ForeColor = SystemColors.ControlDarkDark;
            lbl_insumos.Location = new Point(63, 19);
            lbl_insumos.Name = "lbl_insumos";
            lbl_insumos.Size = new Size(69, 20);
            lbl_insumos.TabIndex = 13;
            lbl_insumos.Text = "Insumos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 77);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lbl_cod_insumo
            // 
            lbl_cod_insumo.AutoSize = true;
            lbl_cod_insumo.BackColor = Color.White;
            lbl_cod_insumo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cod_insumo.ForeColor = SystemColors.ControlDarkDark;
            lbl_cod_insumo.Location = new Point(30, 76);
            lbl_cod_insumo.Name = "lbl_cod_insumo";
            lbl_cod_insumo.Size = new Size(122, 17);
            lbl_cod_insumo.TabIndex = 15;
            lbl_cod_insumo.Text = "Código do Insumo";
            // 
            // lbl_nome_insumo
            // 
            lbl_nome_insumo.AutoSize = true;
            lbl_nome_insumo.BackColor = Color.White;
            lbl_nome_insumo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome_insumo.ForeColor = SystemColors.ControlDarkDark;
            lbl_nome_insumo.Location = new Point(224, 76);
            lbl_nome_insumo.Name = "lbl_nome_insumo";
            lbl_nome_insumo.Size = new Size(45, 17);
            lbl_nome_insumo.TabIndex = 16;
            lbl_nome_insumo.Text = "Nome";
            // 
            // lbl_status_insumo
            // 
            lbl_status_insumo.AutoSize = true;
            lbl_status_insumo.BackColor = Color.White;
            lbl_status_insumo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_status_insumo.ForeColor = SystemColors.ControlDarkDark;
            lbl_status_insumo.Location = new Point(423, 75);
            lbl_status_insumo.Name = "lbl_status_insumo";
            lbl_status_insumo.Size = new Size(46, 17);
            lbl_status_insumo.TabIndex = 21;
            lbl_status_insumo.Text = "Status";
            // 
            // txtbox_cod_insumo
            // 
            txtbox_cod_insumo.Location = new Point(30, 96);
            txtbox_cod_insumo.Name = "txtbox_cod_insumo";
            txtbox_cod_insumo.Size = new Size(159, 23);
            txtbox_cod_insumo.TabIndex = 22;
            // 
            // txtbox_nome_insumo
            // 
            txtbox_nome_insumo.Location = new Point(224, 96);
            txtbox_nome_insumo.Name = "txtbox_nome_insumo";
            txtbox_nome_insumo.Size = new Size(159, 23);
            txtbox_nome_insumo.TabIndex = 23;
            // 
            // combobox_status_insumo
            // 
            combobox_status_insumo.FormattingEnabled = true;
            combobox_status_insumo.Location = new Point(423, 95);
            combobox_status_insumo.Name = "combobox_status_insumo";
            combobox_status_insumo.Size = new Size(187, 23);
            combobox_status_insumo.TabIndex = 24;
            // 
            // btn_add_insumo
            // 
            btn_add_insumo.BackColor = Color.Green;
            btn_add_insumo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_insumo.ForeColor = Color.White;
            btn_add_insumo.Location = new Point(651, 94);
            btn_add_insumo.Name = "btn_add_insumo";
            btn_add_insumo.Size = new Size(144, 23);
            btn_add_insumo.TabIndex = 25;
            btn_add_insumo.Text = "Adicionar Insumo";
            btn_add_insumo.UseVisualStyleBackColor = false;
            btn_add_insumo.Click += btn_add_insumo_Click;
            // 
            // btn_consultar_insumo
            // 
            btn_consultar_insumo.BackColor = Color.Green;
            btn_consultar_insumo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar_insumo.ForeColor = Color.White;
            btn_consultar_insumo.Location = new Point(834, 94);
            btn_consultar_insumo.Name = "btn_consultar_insumo";
            btn_consultar_insumo.Size = new Size(144, 23);
            btn_consultar_insumo.TabIndex = 26;
            btn_consultar_insumo.Text = "Consultar Insumo";
            btn_consultar_insumo.UseVisualStyleBackColor = false;
            btn_consultar_insumo.Click += btn_consultar_insumo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(984, 447);
            dataGridView1.TabIndex = 27;
            // 
            // btn_insumos_voltar
            // 
            btn_insumos_voltar.BackColor = Color.Red;
            btn_insumos_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_insumos_voltar.ForeColor = SystemColors.Control;
            btn_insumos_voltar.Location = new Point(30, 632);
            btn_insumos_voltar.Name = "btn_insumos_voltar";
            btn_insumos_voltar.Size = new Size(75, 23);
            btn_insumos_voltar.TabIndex = 79;
            btn_insumos_voltar.Text = "Voltar";
            btn_insumos_voltar.UseVisualStyleBackColor = false;
            btn_insumos_voltar.Click += btn_insumos_voltar_Click;
            // 
            // TelaInsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1008, 681);
            Controls.Add(btn_insumos_voltar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_consultar_insumo);
            Controls.Add(btn_add_insumo);
            Controls.Add(combobox_status_insumo);
            Controls.Add(txtbox_nome_insumo);
            Controls.Add(txtbox_cod_insumo);
            Controls.Add(lbl_status_insumo);
            Controls.Add(lbl_nome_insumo);
            Controls.Add(lbl_cod_insumo);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_insumos);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "TelaInsumos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaInsumos_FormClosing;
            Load += TelaInsumos_Load;
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
        private Label lbl_insumos;
        private PictureBox pictureBox1;
        private Label lbl_cod_insumo;
        private Label lbl_nome_insumo;
        private Label lbl_status_insumo;
        private TextBox txtbox_cod_insumo;
        private TextBox txtbox_nome_insumo;
        private ComboBox combobox_status_insumo;
        private Button btn_add_insumo;
        private Button btn_consultar_insumo;
        private Button btn_insumos_voltar;
        public DataGridView dataGridView1;
    }
}