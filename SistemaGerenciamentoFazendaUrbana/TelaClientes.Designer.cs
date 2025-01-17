namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaClientes
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
            lbl_cod_cliente = new Label();
            lbl_nome_cliente = new Label();
            lbl_status_cliente = new Label();
            txtbox_cod_cliente = new TextBox();
            txtbox_nome_cliente = new TextBox();
            combobox_status_cliente = new ComboBox();
            btn_add_cliente = new Button();
            btn_editar_cliente = new Button();
            btn_consultar_cliente = new Button();
            dataGridView1 = new DataGridView();
            btn_clientes_voltar = new Button();
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
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // lbl_clientes
            // 
            lbl_clientes.AutoSize = true;
            lbl_clientes.BackColor = Color.White;
            lbl_clientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_clientes.ForeColor = SystemColors.ControlDarkDark;
            lbl_clientes.Location = new Point(65, 19);
            lbl_clientes.Name = "lbl_clientes";
            lbl_clientes.Size = new Size(64, 20);
            lbl_clientes.TabIndex = 15;
            lbl_clientes.Text = "Clientes";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 131);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lbl_cod_cliente
            // 
            lbl_cod_cliente.AutoSize = true;
            lbl_cod_cliente.BackColor = Color.White;
            lbl_cod_cliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cod_cliente.ForeColor = SystemColors.ControlDarkDark;
            lbl_cod_cliente.Location = new Point(35, 81);
            lbl_cod_cliente.Name = "lbl_cod_cliente";
            lbl_cod_cliente.Size = new Size(119, 17);
            lbl_cod_cliente.TabIndex = 17;
            lbl_cod_cliente.Text = "Código do Cliente";
            // 
            // lbl_nome_cliente
            // 
            lbl_nome_cliente.AutoSize = true;
            lbl_nome_cliente.BackColor = Color.White;
            lbl_nome_cliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome_cliente.ForeColor = SystemColors.ControlDarkDark;
            lbl_nome_cliente.Location = new Point(247, 81);
            lbl_nome_cliente.Name = "lbl_nome_cliente";
            lbl_nome_cliente.Size = new Size(112, 17);
            lbl_nome_cliente.TabIndex = 18;
            lbl_nome_cliente.Text = "Nome do Cliente";
            // 
            // lbl_status_cliente
            // 
            lbl_status_cliente.AutoSize = true;
            lbl_status_cliente.BackColor = Color.White;
            lbl_status_cliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_status_cliente.ForeColor = SystemColors.ControlDarkDark;
            lbl_status_cliente.Location = new Point(464, 81);
            lbl_status_cliente.Name = "lbl_status_cliente";
            lbl_status_cliente.Size = new Size(46, 17);
            lbl_status_cliente.TabIndex = 19;
            lbl_status_cliente.Text = "Status";
            // 
            // txtbox_cod_cliente
            // 
            txtbox_cod_cliente.Location = new Point(35, 101);
            txtbox_cod_cliente.Name = "txtbox_cod_cliente";
            txtbox_cod_cliente.Size = new Size(159, 23);
            txtbox_cod_cliente.TabIndex = 0;
            // 
            // txtbox_nome_cliente
            // 
            txtbox_nome_cliente.Location = new Point(247, 101);
            txtbox_nome_cliente.Name = "txtbox_nome_cliente";
            txtbox_nome_cliente.Size = new Size(159, 23);
            txtbox_nome_cliente.TabIndex = 1;
            // 
            // combobox_status_cliente
            // 
            combobox_status_cliente.FormattingEnabled = true;
            combobox_status_cliente.Location = new Point(464, 101);
            combobox_status_cliente.Name = "combobox_status_cliente";
            combobox_status_cliente.Size = new Size(187, 23);
            combobox_status_cliente.TabIndex = 2;
            // 
            // btn_add_cliente
            // 
            btn_add_cliente.BackColor = Color.Green;
            btn_add_cliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_cliente.ForeColor = Color.White;
            btn_add_cliente.Location = new Point(35, 153);
            btn_add_cliente.Name = "btn_add_cliente";
            btn_add_cliente.Size = new Size(144, 23);
            btn_add_cliente.TabIndex = 3;
            btn_add_cliente.Text = "Adicionar Cliente";
            btn_add_cliente.UseVisualStyleBackColor = false;
            btn_add_cliente.Click += btn_add_cliente_Click;
            // 
            // btn_editar_cliente
            // 
            btn_editar_cliente.BackColor = Color.Green;
            btn_editar_cliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar_cliente.ForeColor = Color.White;
            btn_editar_cliente.Location = new Point(436, 153);
            btn_editar_cliente.Name = "btn_editar_cliente";
            btn_editar_cliente.Size = new Size(144, 23);
            btn_editar_cliente.TabIndex = 4;
            btn_editar_cliente.Text = "Editar Cliente";
            btn_editar_cliente.UseVisualStyleBackColor = false;
            // 
            // btn_consultar_cliente
            // 
            btn_consultar_cliente.BackColor = Color.Green;
            btn_consultar_cliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar_cliente.ForeColor = Color.White;
            btn_consultar_cliente.Location = new Point(821, 153);
            btn_consultar_cliente.Name = "btn_consultar_cliente";
            btn_consultar_cliente.Size = new Size(144, 23);
            btn_consultar_cliente.TabIndex = 5;
            btn_consultar_cliente.Text = "Consultar Cliente";
            btn_consultar_cliente.UseVisualStyleBackColor = false;
            btn_consultar_cliente.Click += btn_consultar_cliente_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(984, 392);
            dataGridView1.TabIndex = 30;
            // 
            // btn_clientes_voltar
            // 
            btn_clientes_voltar.BackColor = Color.Red;
            btn_clientes_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clientes_voltar.ForeColor = SystemColors.Control;
            btn_clientes_voltar.Location = new Point(35, 631);
            btn_clientes_voltar.Name = "btn_clientes_voltar";
            btn_clientes_voltar.Size = new Size(75, 23);
            btn_clientes_voltar.TabIndex = 6;
            btn_clientes_voltar.Text = "Voltar";
            btn_clientes_voltar.UseVisualStyleBackColor = false;
            btn_clientes_voltar.Click += btn_clientes_voltar_Click;
            // 
            // TelaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1008, 681);
            Controls.Add(btn_clientes_voltar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_consultar_cliente);
            Controls.Add(btn_editar_cliente);
            Controls.Add(btn_add_cliente);
            Controls.Add(combobox_status_cliente);
            Controls.Add(txtbox_nome_cliente);
            Controls.Add(txtbox_cod_cliente);
            Controls.Add(lbl_status_cliente);
            Controls.Add(lbl_nome_cliente);
            Controls.Add(lbl_cod_cliente);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_clientes);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "TelaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaClientes_FormClosing;
            Load += TelaClientes_Load;
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
        private Label lbl_cod_cliente;
        private Label lbl_nome_cliente;
        private Label lbl_status_cliente;
        private TextBox txtbox_cod_cliente;
        private TextBox txtbox_nome_cliente;
        private ComboBox combobox_status_cliente;
        private Button btn_add_cliente;
        private Button btn_editar_cliente;
        private Button btn_consultar_cliente;
        private DataGridView dataGridView1;
        private Button btn_clientes_voltar;
    }
}