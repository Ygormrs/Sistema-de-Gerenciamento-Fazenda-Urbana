namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaFuncionarios
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
            pictureBox1 = new PictureBox();
            btn_add_funcionario = new Button();
            pictureBox3 = new PictureBox();
            lbl_clientes = new Label();
            txtbox_cod_cliente = new TextBox();
            lbl_cod_funcionario = new Label();
            lbl_nome_funcionario = new Label();
            textBox1 = new TextBox();
            lbl_status_funcionario = new Label();
            combobox_status_cliente = new ComboBox();
            btn_editar_funcionario = new Button();
            btn_consultar_funcionario = new Button();
            dataGridView1 = new DataGridView();
            btn_funcionarios_voltar = new Button();
            btn_pesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1009, 47);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 122);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btn_add_funcionario
            // 
            btn_add_funcionario.BackColor = Color.Green;
            btn_add_funcionario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_funcionario.ForeColor = Color.White;
            btn_add_funcionario.Location = new Point(36, 144);
            btn_add_funcionario.Name = "btn_add_funcionario";
            btn_add_funcionario.Size = new Size(144, 23);
            btn_add_funcionario.TabIndex = 28;
            btn_add_funcionario.Text = "Adicionar Funcionario";
            btn_add_funcionario.UseVisualStyleBackColor = false;
            btn_add_funcionario.Click += btn_add_funcionario_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.LogoNexus;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // lbl_clientes
            // 
            lbl_clientes.AutoSize = true;
            lbl_clientes.BackColor = Color.White;
            lbl_clientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_clientes.ForeColor = SystemColors.ControlDarkDark;
            lbl_clientes.Location = new Point(61, 19);
            lbl_clientes.Name = "lbl_clientes";
            lbl_clientes.Size = new Size(98, 20);
            lbl_clientes.TabIndex = 30;
            lbl_clientes.Text = "Funcionários";
            // 
            // txtbox_cod_cliente
            // 
            txtbox_cod_cliente.Location = new Point(36, 100);
            txtbox_cod_cliente.Name = "txtbox_cod_cliente";
            txtbox_cod_cliente.Size = new Size(159, 23);
            txtbox_cod_cliente.TabIndex = 31;
            // 
            // lbl_cod_funcionario
            // 
            lbl_cod_funcionario.AutoSize = true;
            lbl_cod_funcionario.BackColor = Color.White;
            lbl_cod_funcionario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cod_funcionario.ForeColor = SystemColors.ControlDarkDark;
            lbl_cod_funcionario.Location = new Point(36, 81);
            lbl_cod_funcionario.Name = "lbl_cod_funcionario";
            lbl_cod_funcionario.Size = new Size(149, 17);
            lbl_cod_funcionario.TabIndex = 32;
            lbl_cod_funcionario.Text = "Código do Funcionário";
            // 
            // lbl_nome_funcionario
            // 
            lbl_nome_funcionario.AutoSize = true;
            lbl_nome_funcionario.BackColor = Color.White;
            lbl_nome_funcionario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome_funcionario.ForeColor = SystemColors.ControlDarkDark;
            lbl_nome_funcionario.Location = new Point(240, 80);
            lbl_nome_funcionario.Name = "lbl_nome_funcionario";
            lbl_nome_funcionario.Size = new Size(142, 17);
            lbl_nome_funcionario.TabIndex = 33;
            lbl_nome_funcionario.Text = "Nome do Funcionário";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 34;
            // 
            // lbl_status_funcionario
            // 
            lbl_status_funcionario.AutoSize = true;
            lbl_status_funcionario.BackColor = Color.White;
            lbl_status_funcionario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_status_funcionario.ForeColor = SystemColors.ControlDarkDark;
            lbl_status_funcionario.Location = new Point(447, 81);
            lbl_status_funcionario.Name = "lbl_status_funcionario";
            lbl_status_funcionario.Size = new Size(46, 17);
            lbl_status_funcionario.TabIndex = 35;
            lbl_status_funcionario.Text = "Status";
            // 
            // combobox_status_cliente
            // 
            combobox_status_cliente.FormattingEnabled = true;
            combobox_status_cliente.Location = new Point(447, 100);
            combobox_status_cliente.Name = "combobox_status_cliente";
            combobox_status_cliente.Size = new Size(187, 23);
            combobox_status_cliente.TabIndex = 36;
            // 
            // btn_editar_funcionario
            // 
            btn_editar_funcionario.BackColor = Color.Green;
            btn_editar_funcionario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar_funcionario.ForeColor = Color.White;
            btn_editar_funcionario.Location = new Point(240, 144);
            btn_editar_funcionario.Name = "btn_editar_funcionario";
            btn_editar_funcionario.Size = new Size(144, 23);
            btn_editar_funcionario.TabIndex = 37;
            btn_editar_funcionario.Text = "Editar Funcionario";
            btn_editar_funcionario.UseVisualStyleBackColor = false;
            btn_editar_funcionario.Click += btn_editar_funcionario_Click;
            // 
            // btn_consultar_funcionario
            // 
            btn_consultar_funcionario.BackColor = Color.Green;
            btn_consultar_funcionario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar_funcionario.ForeColor = Color.White;
            btn_consultar_funcionario.Location = new Point(447, 144);
            btn_consultar_funcionario.Name = "btn_consultar_funcionario";
            btn_consultar_funcionario.Size = new Size(144, 23);
            btn_consultar_funcionario.TabIndex = 38;
            btn_consultar_funcionario.Text = "Consultar Funcionario";
            btn_consultar_funcionario.UseVisualStyleBackColor = false;
            btn_consultar_funcionario.Click += btn_consultar_funcionario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(984, 429);
            dataGridView1.TabIndex = 39;
            // 
            // btn_funcionarios_voltar
            // 
            btn_funcionarios_voltar.BackColor = Color.Red;
            btn_funcionarios_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_funcionarios_voltar.ForeColor = SystemColors.Control;
            btn_funcionarios_voltar.Location = new Point(36, 637);
            btn_funcionarios_voltar.Name = "btn_funcionarios_voltar";
            btn_funcionarios_voltar.Size = new Size(75, 23);
            btn_funcionarios_voltar.TabIndex = 80;
            btn_funcionarios_voltar.Text = "Voltar";
            btn_funcionarios_voltar.UseVisualStyleBackColor = false;
            btn_funcionarios_voltar.Click += btn_funcionarios_voltar_Click;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(878, 98);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(88, 24);
            btn_pesquisar.TabIndex = 84;
            btn_pesquisar.Text = "Pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // TelaFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(btn_pesquisar);
            Controls.Add(btn_funcionarios_voltar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_consultar_funcionario);
            Controls.Add(btn_editar_funcionario);
            Controls.Add(combobox_status_cliente);
            Controls.Add(lbl_status_funcionario);
            Controls.Add(textBox1);
            Controls.Add(lbl_nome_funcionario);
            Controls.Add(lbl_cod_funcionario);
            Controls.Add(txtbox_cod_cliente);
            Controls.Add(lbl_clientes);
            Controls.Add(pictureBox3);
            Controls.Add(btn_add_funcionario);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "TelaFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionarios";
            FormClosing += TelaFuncionarios_FormClosing;
            Load += TelaFuncionarios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btn_add_funcionario;
        private PictureBox pictureBox3;
        private Label lbl_clientes;
        private TextBox txtbox_cod_cliente;
        private Label lbl_cod_funcionario;
        private Label lbl_nome_funcionario;
        private TextBox textBox1;
        private Label lbl_status_funcionario;
        private ComboBox combobox_status_cliente;
        private Button btn_editar_funcionario;
        private Button btn_consultar_funcionario;
        private DataGridView dataGridView1;
        private Button btn_funcionarios_voltar;
        private Button btn_pesquisar;
    }
}