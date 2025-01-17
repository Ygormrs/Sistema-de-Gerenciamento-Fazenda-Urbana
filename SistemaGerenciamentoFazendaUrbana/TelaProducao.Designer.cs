namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaProducao
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
            lbl_producao = new Label();
            pictureBox1 = new PictureBox();
            lbl_cod_producao = new Label();
            txtbox_cod_producao = new TextBox();
            lbl_classe_producao = new Label();
            combobox_classe_prod = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            lbl_ultima_colheita = new Label();
            lbl_status_producao = new Label();
            combobox_status_prod = new ComboBox();
            btn_add_producao = new Button();
            dataGridView1 = new DataGridView();
            btn_editar_producao = new Button();
            btn_consultar_producao = new Button();
            btn_producao_voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1009, 47);
            pictureBox2.TabIndex = 2;
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
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // lbl_producao
            // 
            lbl_producao.AutoSize = true;
            lbl_producao.BackColor = Color.White;
            lbl_producao.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_producao.ForeColor = SystemColors.ControlDarkDark;
            lbl_producao.Location = new Point(61, 19);
            lbl_producao.Name = "lbl_producao";
            lbl_producao.Size = new Size(75, 20);
            lbl_producao.TabIndex = 12;
            lbl_producao.Text = "Produção";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 122);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lbl_cod_producao
            // 
            lbl_cod_producao.AutoSize = true;
            lbl_cod_producao.BackColor = Color.White;
            lbl_cod_producao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cod_producao.ForeColor = SystemColors.ControlDarkDark;
            lbl_cod_producao.Location = new Point(61, 79);
            lbl_cod_producao.Name = "lbl_cod_producao";
            lbl_cod_producao.Size = new Size(133, 17);
            lbl_cod_producao.TabIndex = 14;
            lbl_cod_producao.Text = "Código da Produção";
            // 
            // txtbox_cod_producao
            // 
            txtbox_cod_producao.Location = new Point(61, 99);
            txtbox_cod_producao.Name = "txtbox_cod_producao";
            txtbox_cod_producao.PlaceholderText = "Digite o Código";
            txtbox_cod_producao.Size = new Size(159, 23);
            txtbox_cod_producao.TabIndex = 15;
            // 
            // lbl_classe_producao
            // 
            lbl_classe_producao.AutoSize = true;
            lbl_classe_producao.BackColor = Color.White;
            lbl_classe_producao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_classe_producao.ForeColor = SystemColors.ControlDarkDark;
            lbl_classe_producao.Location = new Point(282, 79);
            lbl_classe_producao.Name = "lbl_classe_producao";
            lbl_classe_producao.Size = new Size(127, 17);
            lbl_classe_producao.TabIndex = 16;
            lbl_classe_producao.Text = "Classe da Produção";
            // 
            // combobox_classe_prod
            // 
            combobox_classe_prod.FormattingEnabled = true;
            combobox_classe_prod.Location = new Point(282, 99);
            combobox_classe_prod.Name = "combobox_classe_prod";
            combobox_classe_prod.Size = new Size(187, 23);
            combobox_classe_prod.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(534, 99);
            dateTimePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // lbl_ultima_colheita
            // 
            lbl_ultima_colheita.AutoSize = true;
            lbl_ultima_colheita.BackColor = Color.White;
            lbl_ultima_colheita.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ultima_colheita.ForeColor = SystemColors.ControlDarkDark;
            lbl_ultima_colheita.Location = new Point(534, 79);
            lbl_ultima_colheita.Name = "lbl_ultima_colheita";
            lbl_ultima_colheita.Size = new Size(104, 17);
            lbl_ultima_colheita.TabIndex = 19;
            lbl_ultima_colheita.Text = "Última Colheita";
            // 
            // lbl_status_producao
            // 
            lbl_status_producao.AutoSize = true;
            lbl_status_producao.BackColor = Color.White;
            lbl_status_producao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_status_producao.ForeColor = SystemColors.ControlDarkDark;
            lbl_status_producao.Location = new Point(795, 79);
            lbl_status_producao.Name = "lbl_status_producao";
            lbl_status_producao.Size = new Size(46, 17);
            lbl_status_producao.TabIndex = 20;
            lbl_status_producao.Text = "Status";
            // 
            // combobox_status_prod
            // 
            combobox_status_prod.FormattingEnabled = true;
            combobox_status_prod.Location = new Point(795, 99);
            combobox_status_prod.Name = "combobox_status_prod";
            combobox_status_prod.Size = new Size(125, 23);
            combobox_status_prod.TabIndex = 21;
            // 
            // btn_add_producao
            // 
            btn_add_producao.BackColor = Color.Green;
            btn_add_producao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_producao.ForeColor = Color.White;
            btn_add_producao.Location = new Point(61, 146);
            btn_add_producao.Name = "btn_add_producao";
            btn_add_producao.Size = new Size(144, 23);
            btn_add_producao.TabIndex = 22;
            btn_add_producao.Text = "Adicionar Produção";
            btn_add_producao.UseVisualStyleBackColor = false;
            btn_add_producao.Click += btn_add_producao_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(984, 391);
            dataGridView1.TabIndex = 23;
            // 
            // btn_editar_producao
            // 
            btn_editar_producao.BackColor = Color.Green;
            btn_editar_producao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar_producao.ForeColor = Color.White;
            btn_editar_producao.Location = new Point(426, 146);
            btn_editar_producao.Name = "btn_editar_producao";
            btn_editar_producao.Size = new Size(144, 23);
            btn_editar_producao.TabIndex = 24;
            btn_editar_producao.Text = "Editar Produção";
            btn_editar_producao.UseVisualStyleBackColor = false;
            // 
            // btn_consultar_producao
            // 
            btn_consultar_producao.BackColor = Color.Green;
            btn_consultar_producao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar_producao.ForeColor = Color.White;
            btn_consultar_producao.Location = new Point(776, 146);
            btn_consultar_producao.Name = "btn_consultar_producao";
            btn_consultar_producao.Size = new Size(144, 23);
            btn_consultar_producao.TabIndex = 25;
            btn_consultar_producao.Text = "Consultar Produção";
            btn_consultar_producao.UseVisualStyleBackColor = false;
            btn_consultar_producao.Click += btn_consultar_producao_Click;
            // 
            // btn_producao_voltar
            // 
            btn_producao_voltar.BackColor = Color.Red;
            btn_producao_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_producao_voltar.ForeColor = SystemColors.Control;
            btn_producao_voltar.Location = new Point(61, 627);
            btn_producao_voltar.Name = "btn_producao_voltar";
            btn_producao_voltar.Size = new Size(75, 23);
            btn_producao_voltar.TabIndex = 79;
            btn_producao_voltar.Text = "Voltar";
            btn_producao_voltar.UseVisualStyleBackColor = false;
            btn_producao_voltar.Click += btn_producao_voltar_Click;
            // 
            // TelaProducao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1008, 681);
            Controls.Add(btn_producao_voltar);
            Controls.Add(btn_consultar_producao);
            Controls.Add(btn_editar_producao);
            Controls.Add(dataGridView1);
            Controls.Add(btn_add_producao);
            Controls.Add(combobox_status_prod);
            Controls.Add(lbl_status_producao);
            Controls.Add(lbl_ultima_colheita);
            Controls.Add(dateTimePicker1);
            Controls.Add(combobox_classe_prod);
            Controls.Add(lbl_classe_producao);
            Controls.Add(txtbox_cod_producao);
            Controls.Add(lbl_cod_producao);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_producao);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            MaximizeBox = false;
            Name = "TelaProducao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaProducao_FormClosing;
            Load += TelaProducao_Load;
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
        private Label lbl_producao;
        private PictureBox pictureBox1;
        private Label lbl_cod_producao;
        private TextBox txtbox_cod_producao;
        private Label lbl_classe_producao;
        private ComboBox combobox_classe_prod;
        private DateTimePicker dateTimePicker1;
        private Label lbl_ultima_colheita;
        private Label lbl_status_producao;
        private ComboBox combobox_status_prod;
        private Button btn_add_producao;
        private Button btn_editar_producao;
        private Button btn_consultar_producao;
        private Button btn_producao_voltar;
        public DataGridView dataGridView1;
    }
}