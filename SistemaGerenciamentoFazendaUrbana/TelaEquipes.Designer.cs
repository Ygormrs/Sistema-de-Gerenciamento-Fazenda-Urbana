namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaEquipes
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
            lbl_equipes = new Label();
            pictureBox1 = new PictureBox();
            lbl_cod_equipe = new Label();
            txtbox_cod_equipe = new TextBox();
            lbl_status_equipe = new Label();
            combobox_status_equipe = new ComboBox();
            btn_add_equipe = new Button();
            btn_editarquipe = new Button();
            dataGridView1 = new DataGridView();
            btn_equipes_voltar = new Button();
            btn_consulta_equipe = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1009, 47);
            pictureBox2.TabIndex = 6;
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
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // lbl_equipes
            // 
            lbl_equipes.AutoSize = true;
            lbl_equipes.BackColor = Color.White;
            lbl_equipes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_equipes.ForeColor = SystemColors.ControlDarkDark;
            lbl_equipes.Location = new Point(72, 19);
            lbl_equipes.Name = "lbl_equipes";
            lbl_equipes.Size = new Size(63, 20);
            lbl_equipes.TabIndex = 17;
            lbl_equipes.Text = "Equipes";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 77);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lbl_cod_equipe
            // 
            lbl_cod_equipe.AutoSize = true;
            lbl_cod_equipe.BackColor = Color.White;
            lbl_cod_equipe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cod_equipe.ForeColor = SystemColors.ControlDarkDark;
            lbl_cod_equipe.Location = new Point(33, 77);
            lbl_cod_equipe.Name = "lbl_cod_equipe";
            lbl_cod_equipe.Size = new Size(117, 17);
            lbl_cod_equipe.TabIndex = 19;
            lbl_cod_equipe.Text = "Código da Equipe";
            // 
            // txtbox_cod_equipe
            // 
            txtbox_cod_equipe.Location = new Point(33, 97);
            txtbox_cod_equipe.Name = "txtbox_cod_equipe";
            txtbox_cod_equipe.Size = new Size(159, 23);
            txtbox_cod_equipe.TabIndex = 26;
            // 
            // lbl_status_equipe
            // 
            lbl_status_equipe.AutoSize = true;
            lbl_status_equipe.BackColor = Color.White;
            lbl_status_equipe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_status_equipe.ForeColor = SystemColors.ControlDarkDark;
            lbl_status_equipe.Location = new Point(224, 77);
            lbl_status_equipe.Name = "lbl_status_equipe";
            lbl_status_equipe.Size = new Size(46, 17);
            lbl_status_equipe.TabIndex = 27;
            lbl_status_equipe.Text = "Status";
            // 
            // combobox_status_equipe
            // 
            combobox_status_equipe.FormattingEnabled = true;
            combobox_status_equipe.Location = new Point(224, 97);
            combobox_status_equipe.Name = "combobox_status_equipe";
            combobox_status_equipe.Size = new Size(187, 23);
            combobox_status_equipe.TabIndex = 28;
            // 
            // btn_add_equipe
            // 
            btn_add_equipe.BackColor = Color.Green;
            btn_add_equipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_equipe.ForeColor = Color.White;
            btn_add_equipe.Location = new Point(454, 97);
            btn_add_equipe.Name = "btn_add_equipe";
            btn_add_equipe.Size = new Size(144, 23);
            btn_add_equipe.TabIndex = 29;
            btn_add_equipe.Text = "Adicionar Equipe";
            btn_add_equipe.UseVisualStyleBackColor = false;
            btn_add_equipe.Click += btn_add_equipe_Click;
            // 
            // btn_editarquipe
            // 
            btn_editarquipe.BackColor = Color.Green;
            btn_editarquipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editarquipe.ForeColor = Color.White;
            btn_editarquipe.Location = new Point(646, 96);
            btn_editarquipe.Name = "btn_editarquipe";
            btn_editarquipe.Size = new Size(144, 23);
            btn_editarquipe.TabIndex = 30;
            btn_editarquipe.Text = "Editar Equipe";
            btn_editarquipe.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(984, 442);
            dataGridView1.TabIndex = 31;
            // 
            // btn_equipes_voltar
            // 
            btn_equipes_voltar.BackColor = Color.Red;
            btn_equipes_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_equipes_voltar.ForeColor = SystemColors.Control;
            btn_equipes_voltar.Location = new Point(33, 630);
            btn_equipes_voltar.Name = "btn_equipes_voltar";
            btn_equipes_voltar.Size = new Size(75, 23);
            btn_equipes_voltar.TabIndex = 80;
            btn_equipes_voltar.Text = "Voltar";
            btn_equipes_voltar.UseVisualStyleBackColor = false;
            btn_equipes_voltar.Click += btn_equipes_voltar_Click;
            // 
            // btn_consulta_equipe
            // 
            btn_consulta_equipe.BackColor = Color.Green;
            btn_consulta_equipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consulta_equipe.ForeColor = Color.White;
            btn_consulta_equipe.Location = new Point(831, 96);
            btn_consulta_equipe.Name = "btn_consulta_equipe";
            btn_consulta_equipe.Size = new Size(144, 23);
            btn_consulta_equipe.TabIndex = 81;
            btn_consulta_equipe.Text = "Consultar Equipe";
            btn_consulta_equipe.UseVisualStyleBackColor = false;
            btn_consulta_equipe.Click += btn_consulta_equipe_Click;
            // 
            // TelaEquipes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(btn_consulta_equipe);
            Controls.Add(btn_equipes_voltar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_editarquipe);
            Controls.Add(btn_add_equipe);
            Controls.Add(combobox_status_equipe);
            Controls.Add(lbl_status_equipe);
            Controls.Add(txtbox_cod_equipe);
            Controls.Add(lbl_cod_equipe);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_equipes);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "TelaEquipes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaEquipes_FormClosing;
            Load += TelaEquipes_Load;
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
        private Label lbl_equipes;
        private PictureBox pictureBox1;
        private Label lbl_cod_equipe;
        private TextBox txtbox_cod_equipe;
        private Label lbl_status_equipe;
        private ComboBox combobox_status_equipe;
        private Button btn_add_equipe;
        private Button btn_editarquipe;
        private DataGridView dataGridView1;
        private Button btn_equipes_voltar;
        private Button btn_consulta_equipe;
    }
}