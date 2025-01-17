namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaVendas
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
            lbl_vendas = new Label();
            pictureBox1 = new PictureBox();
            lbl_cod_equipe = new Label();
            txtbox_venda_cliente = new TextBox();
            lbl_status_equipe = new Label();
            combobox_status_venda = new ComboBox();
            btn_add_venda = new Button();
            dataGridView1 = new DataGridView();
            btn_vendas_voltar = new Button();
            btn_consultar_venda = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(0, 0);
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
            // lbl_vendas
            // 
            lbl_vendas.AutoSize = true;
            lbl_vendas.BackColor = Color.White;
            lbl_vendas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_vendas.ForeColor = SystemColors.ControlDarkDark;
            lbl_vendas.Location = new Point(73, 19);
            lbl_vendas.Name = "lbl_vendas";
            lbl_vendas.Size = new Size(59, 20);
            lbl_vendas.TabIndex = 17;
            lbl_vendas.Text = "Vendas";
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
            lbl_cod_equipe.Location = new Point(36, 77);
            lbl_cod_equipe.Name = "lbl_cod_equipe";
            lbl_cod_equipe.Size = new Size(51, 17);
            lbl_cod_equipe.TabIndex = 19;
            lbl_cod_equipe.Text = "Cliente";
            // 
            // txtbox_venda_cliente
            // 
            txtbox_venda_cliente.Location = new Point(36, 97);
            txtbox_venda_cliente.Name = "txtbox_venda_cliente";
            txtbox_venda_cliente.Size = new Size(159, 23);
            txtbox_venda_cliente.TabIndex = 0;
            // 
            // lbl_status_equipe
            // 
            lbl_status_equipe.AutoSize = true;
            lbl_status_equipe.BackColor = Color.White;
            lbl_status_equipe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_status_equipe.ForeColor = SystemColors.ControlDarkDark;
            lbl_status_equipe.Location = new Point(263, 77);
            lbl_status_equipe.Name = "lbl_status_equipe";
            lbl_status_equipe.Size = new Size(46, 17);
            lbl_status_equipe.TabIndex = 30;
            lbl_status_equipe.Text = "Status";
            // 
            // combobox_status_venda
            // 
            combobox_status_venda.FormattingEnabled = true;
            combobox_status_venda.Location = new Point(263, 96);
            combobox_status_venda.Name = "combobox_status_venda";
            combobox_status_venda.Size = new Size(159, 23);
            combobox_status_venda.TabIndex = 1;
            // 
            // btn_add_venda
            // 
            btn_add_venda.BackColor = Color.Green;
            btn_add_venda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_venda.ForeColor = Color.White;
            btn_add_venda.Location = new Point(655, 97);
            btn_add_venda.Name = "btn_add_venda";
            btn_add_venda.Size = new Size(144, 23);
            btn_add_venda.TabIndex = 2;
            btn_add_venda.Text = "Cadastrar Venda";
            btn_add_venda.UseVisualStyleBackColor = false;
            btn_add_venda.Click += btn_add_venda_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(984, 457);
            dataGridView1.TabIndex = 33;
            // 
            // btn_vendas_voltar
            // 
            btn_vendas_voltar.BackColor = Color.Red;
            btn_vendas_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_vendas_voltar.ForeColor = SystemColors.Control;
            btn_vendas_voltar.Location = new Point(36, 629);
            btn_vendas_voltar.Name = "btn_vendas_voltar";
            btn_vendas_voltar.Size = new Size(75, 23);
            btn_vendas_voltar.TabIndex = 3;
            btn_vendas_voltar.Text = "Voltar";
            btn_vendas_voltar.UseVisualStyleBackColor = false;
            btn_vendas_voltar.Click += btn_vendas_voltar_Click;
            // 
            // btn_consultar_venda
            // 
            btn_consultar_venda.BackColor = Color.Green;
            btn_consultar_venda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar_venda.ForeColor = Color.White;
            btn_consultar_venda.Location = new Point(830, 96);
            btn_consultar_venda.Name = "btn_consultar_venda";
            btn_consultar_venda.Size = new Size(144, 23);
            btn_consultar_venda.TabIndex = 34;
            btn_consultar_venda.Text = "Consultar Venda";
            btn_consultar_venda.UseVisualStyleBackColor = false;
            btn_consultar_venda.Click += btn_consultar_venda_Click;
            // 
            // TelaVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(btn_consultar_venda);
            Controls.Add(btn_vendas_voltar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_add_venda);
            Controls.Add(combobox_status_venda);
            Controls.Add(lbl_status_equipe);
            Controls.Add(txtbox_venda_cliente);
            Controls.Add(lbl_cod_equipe);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_vendas);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "TelaVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaVendas_FormClosing;
            Load += TelaVendas_Load;
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
        private Label lbl_vendas;
        private PictureBox pictureBox1;
        private Label lbl_cod_equipe;
        private TextBox txtbox_venda_cliente;
        private Label lbl_status_equipe;
        private ComboBox combobox_status_venda;
        private Button btn_add_venda;
        private DataGridView dataGridView1;
        private Button btn_vendas_voltar;
        private Button btn_consultar_venda;
    }
}