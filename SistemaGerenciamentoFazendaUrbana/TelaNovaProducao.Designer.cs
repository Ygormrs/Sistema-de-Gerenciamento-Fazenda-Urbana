namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaNovaProducao
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
            lbl_novaproducao = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_dadosdaproducao = new Label();
            lbl_np_nomedoproduto = new Label();
            lbl_np_classe = new Label();
            lbl_np_tempo_maturacao = new Label();
            lbl_medida_tempo = new Label();
            combobox_np_classe = new ComboBox();
            combobox_np_medidadetempo = new ComboBox();
            lbl_np_umidade = new Label();
            lbl_np_temperatura = new Label();
            lbl_np_niveldeluz = new Label();
            lbl_np_status = new Label();
            txtbox_np_umidade = new TextBox();
            txtbox_np_temperatura = new TextBox();
            txtbox_np_niveldeluz = new TextBox();
            btn_np_salvar = new Button();
            btn_np_voltar = new Button();
            txtbox_np_tempomedio = new TextBox();
            txtbox_np_nomedoproduto = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lbl_np_data = new Label();
            rb_np_status_ativo = new RadioButton();
            rb_np_status_inativo = new RadioButton();
            lbl_cod_np = new Label();
            txtbox_np_codigoprod = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1009, 47);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lbl_novaproducao
            // 
            lbl_novaproducao.AutoSize = true;
            lbl_novaproducao.BackColor = Color.White;
            lbl_novaproducao.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_novaproducao.ForeColor = SystemColors.ControlDarkDark;
            lbl_novaproducao.Location = new Point(66, 19);
            lbl_novaproducao.Name = "lbl_novaproducao";
            lbl_novaproducao.Size = new Size(116, 20);
            lbl_novaproducao.TabIndex = 18;
            lbl_novaproducao.Text = "Nova Produção";
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
            pictureBox1.Location = new Point(12, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 531);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // lbl_dadosdaproducao
            // 
            lbl_dadosdaproducao.AutoSize = true;
            lbl_dadosdaproducao.BackColor = Color.White;
            lbl_dadosdaproducao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dadosdaproducao.ForeColor = Color.Green;
            lbl_dadosdaproducao.Location = new Point(38, 85);
            lbl_dadosdaproducao.Name = "lbl_dadosdaproducao";
            lbl_dadosdaproducao.Size = new Size(158, 21);
            lbl_dadosdaproducao.TabIndex = 21;
            lbl_dadosdaproducao.Text = "Dados da Produção";
            // 
            // lbl_np_nomedoproduto
            // 
            lbl_np_nomedoproduto.AutoSize = true;
            lbl_np_nomedoproduto.BackColor = Color.White;
            lbl_np_nomedoproduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_np_nomedoproduto.ForeColor = SystemColors.ControlDarkDark;
            lbl_np_nomedoproduto.Location = new Point(38, 144);
            lbl_np_nomedoproduto.Name = "lbl_np_nomedoproduto";
            lbl_np_nomedoproduto.Size = new Size(106, 15);
            lbl_np_nomedoproduto.TabIndex = 22;
            lbl_np_nomedoproduto.Text = "Nome do Produto";
            // 
            // lbl_np_classe
            // 
            lbl_np_classe.AutoSize = true;
            lbl_np_classe.BackColor = Color.White;
            lbl_np_classe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_np_classe.ForeColor = SystemColors.ControlDarkDark;
            lbl_np_classe.Location = new Point(318, 144);
            lbl_np_classe.Name = "lbl_np_classe";
            lbl_np_classe.Size = new Size(40, 15);
            lbl_np_classe.TabIndex = 23;
            lbl_np_classe.Text = "Classe";
            // 
            // lbl_np_tempo_maturacao
            // 
            lbl_np_tempo_maturacao.AutoSize = true;
            lbl_np_tempo_maturacao.BackColor = Color.White;
            lbl_np_tempo_maturacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_np_tempo_maturacao.ForeColor = SystemColors.ControlDarkDark;
            lbl_np_tempo_maturacao.Location = new Point(510, 144);
            lbl_np_tempo_maturacao.Name = "lbl_np_tempo_maturacao";
            lbl_np_tempo_maturacao.Size = new Size(162, 15);
            lbl_np_tempo_maturacao.TabIndex = 24;
            lbl_np_tempo_maturacao.Text = "Tempo Médio de Maturação";
            // 
            // lbl_medida_tempo
            // 
            lbl_medida_tempo.AutoSize = true;
            lbl_medida_tempo.BackColor = Color.White;
            lbl_medida_tempo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_medida_tempo.ForeColor = SystemColors.ControlDarkDark;
            lbl_medida_tempo.Location = new Point(785, 144);
            lbl_medida_tempo.Name = "lbl_medida_tempo";
            lbl_medida_tempo.Size = new Size(106, 15);
            lbl_medida_tempo.TabIndex = 25;
            lbl_medida_tempo.Text = "Medida de Tempo";
            // 
            // combobox_np_classe
            // 
            combobox_np_classe.FormattingEnabled = true;
            combobox_np_classe.Location = new Point(318, 162);
            combobox_np_classe.Name = "combobox_np_classe";
            combobox_np_classe.Size = new Size(127, 23);
            combobox_np_classe.TabIndex = 2;
            // 
            // combobox_np_medidadetempo
            // 
            combobox_np_medidadetempo.FormattingEnabled = true;
            combobox_np_medidadetempo.Location = new Point(785, 162);
            combobox_np_medidadetempo.Name = "combobox_np_medidadetempo";
            combobox_np_medidadetempo.Size = new Size(174, 23);
            combobox_np_medidadetempo.TabIndex = 4;
            // 
            // lbl_np_umidade
            // 
            lbl_np_umidade.AutoSize = true;
            lbl_np_umidade.BackColor = Color.White;
            lbl_np_umidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_np_umidade.ForeColor = SystemColors.ControlDarkDark;
            lbl_np_umidade.Location = new Point(38, 220);
            lbl_np_umidade.Name = "lbl_np_umidade";
            lbl_np_umidade.Size = new Size(57, 15);
            lbl_np_umidade.TabIndex = 31;
            lbl_np_umidade.Text = "Umidade";
            // 
            // lbl_np_temperatura
            // 
            lbl_np_temperatura.AutoSize = true;
            lbl_np_temperatura.BackColor = Color.White;
            lbl_np_temperatura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_np_temperatura.ForeColor = SystemColors.ControlDarkDark;
            lbl_np_temperatura.Location = new Point(318, 220);
            lbl_np_temperatura.Name = "lbl_np_temperatura";
            lbl_np_temperatura.Size = new Size(79, 15);
            lbl_np_temperatura.TabIndex = 32;
            lbl_np_temperatura.Text = "Temperatura";
            // 
            // lbl_np_niveldeluz
            // 
            lbl_np_niveldeluz.AutoSize = true;
            lbl_np_niveldeluz.BackColor = Color.White;
            lbl_np_niveldeluz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_np_niveldeluz.ForeColor = SystemColors.ControlDarkDark;
            lbl_np_niveldeluz.Location = new Point(510, 220);
            lbl_np_niveldeluz.Name = "lbl_np_niveldeluz";
            lbl_np_niveldeluz.Size = new Size(75, 15);
            lbl_np_niveldeluz.TabIndex = 33;
            lbl_np_niveldeluz.Text = "Nivel de Luz";
            // 
            // lbl_np_status
            // 
            lbl_np_status.AutoSize = true;
            lbl_np_status.BackColor = Color.White;
            lbl_np_status.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_np_status.ForeColor = SystemColors.ControlDarkDark;
            lbl_np_status.Location = new Point(785, 220);
            lbl_np_status.Name = "lbl_np_status";
            lbl_np_status.Size = new Size(42, 15);
            lbl_np_status.TabIndex = 34;
            lbl_np_status.Text = "Status";
            // 
            // txtbox_np_umidade
            // 
            txtbox_np_umidade.Location = new Point(38, 238);
            txtbox_np_umidade.Name = "txtbox_np_umidade";
            txtbox_np_umidade.Size = new Size(198, 23);
            txtbox_np_umidade.TabIndex = 5;
            // 
            // txtbox_np_temperatura
            // 
            txtbox_np_temperatura.Location = new Point(318, 238);
            txtbox_np_temperatura.Name = "txtbox_np_temperatura";
            txtbox_np_temperatura.Size = new Size(127, 23);
            txtbox_np_temperatura.TabIndex = 6;
            // 
            // txtbox_np_niveldeluz
            // 
            txtbox_np_niveldeluz.Location = new Point(510, 238);
            txtbox_np_niveldeluz.Name = "txtbox_np_niveldeluz";
            txtbox_np_niveldeluz.Size = new Size(227, 23);
            txtbox_np_niveldeluz.TabIndex = 7;
            // 
            // btn_np_salvar
            // 
            btn_np_salvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_np_salvar.Location = new Point(884, 626);
            btn_np_salvar.Name = "btn_np_salvar";
            btn_np_salvar.Size = new Size(75, 23);
            btn_np_salvar.TabIndex = 44;
            btn_np_salvar.Text = "Salvar";
            btn_np_salvar.UseVisualStyleBackColor = true;
            btn_np_salvar.Click += btn_np_salvar_Click;
            // 
            // btn_np_voltar
            // 
            btn_np_voltar.BackColor = Color.Red;
            btn_np_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_np_voltar.ForeColor = SystemColors.Control;
            btn_np_voltar.Location = new Point(38, 626);
            btn_np_voltar.Name = "btn_np_voltar";
            btn_np_voltar.Size = new Size(75, 23);
            btn_np_voltar.TabIndex = 45;
            btn_np_voltar.Text = "Voltar";
            btn_np_voltar.UseVisualStyleBackColor = false;
            btn_np_voltar.Click += btn_np_voltar_Click;
            // 
            // txtbox_np_tempomedio
            // 
            txtbox_np_tempomedio.Location = new Point(510, 162);
            txtbox_np_tempomedio.Name = "txtbox_np_tempomedio";
            txtbox_np_tempomedio.Size = new Size(227, 23);
            txtbox_np_tempomedio.TabIndex = 3;
            // 
            // txtbox_np_nomedoproduto
            // 
            txtbox_np_nomedoproduto.Location = new Point(38, 162);
            txtbox_np_nomedoproduto.Name = "txtbox_np_nomedoproduto";
            txtbox_np_nomedoproduto.Size = new Size(227, 23);
            txtbox_np_nomedoproduto.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(732, 85);
            dateTimePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(227, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // lbl_np_data
            // 
            lbl_np_data.AutoSize = true;
            lbl_np_data.BackColor = Color.White;
            lbl_np_data.Location = new Point(625, 91);
            lbl_np_data.Name = "lbl_np_data";
            lbl_np_data.Size = new Size(101, 15);
            lbl_np_data.TabIndex = 51;
            lbl_np_data.Text = "Data da Producao";
            // 
            // rb_np_status_ativo
            // 
            rb_np_status_ativo.AutoSize = true;
            rb_np_status_ativo.BackColor = Color.White;
            rb_np_status_ativo.Checked = true;
            rb_np_status_ativo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_np_status_ativo.ForeColor = SystemColors.ControlDarkDark;
            rb_np_status_ativo.Location = new Point(785, 242);
            rb_np_status_ativo.Name = "rb_np_status_ativo";
            rb_np_status_ativo.Size = new Size(55, 19);
            rb_np_status_ativo.TabIndex = 123;
            rb_np_status_ativo.TabStop = true;
            rb_np_status_ativo.Text = "Ativo";
            rb_np_status_ativo.UseVisualStyleBackColor = false;
            // 
            // rb_np_status_inativo
            // 
            rb_np_status_inativo.AutoSize = true;
            rb_np_status_inativo.BackColor = Color.White;
            rb_np_status_inativo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_np_status_inativo.ForeColor = SystemColors.ControlDarkDark;
            rb_np_status_inativo.Location = new Point(846, 242);
            rb_np_status_inativo.Name = "rb_np_status_inativo";
            rb_np_status_inativo.Size = new Size(64, 19);
            rb_np_status_inativo.TabIndex = 124;
            rb_np_status_inativo.Text = "Inativo";
            rb_np_status_inativo.UseVisualStyleBackColor = false;
            // 
            // lbl_cod_np
            // 
            lbl_cod_np.AutoSize = true;
            lbl_cod_np.BackColor = Color.White;
            lbl_cod_np.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cod_np.ForeColor = SystemColors.ControlDarkDark;
            lbl_cod_np.Location = new Point(329, 91);
            lbl_cod_np.Name = "lbl_cod_np";
            lbl_cod_np.Size = new Size(116, 15);
            lbl_cod_np.TabIndex = 153;
            lbl_cod_np.Text = "Codigo da Produção";
            // 
            // txtbox_np_codigoprod
            // 
            txtbox_np_codigoprod.Location = new Point(451, 85);
            txtbox_np_codigoprod.Name = "txtbox_np_codigoprod";
            txtbox_np_codigoprod.ReadOnly = true;
            txtbox_np_codigoprod.Size = new Size(78, 23);
            txtbox_np_codigoprod.TabIndex = 154;
            // 
            // TelaNovaProducao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(txtbox_np_codigoprod);
            Controls.Add(lbl_cod_np);
            Controls.Add(rb_np_status_inativo);
            Controls.Add(rb_np_status_ativo);
            Controls.Add(lbl_np_data);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtbox_np_nomedoproduto);
            Controls.Add(btn_np_voltar);
            Controls.Add(btn_np_salvar);
            Controls.Add(txtbox_np_niveldeluz);
            Controls.Add(txtbox_np_temperatura);
            Controls.Add(txtbox_np_umidade);
            Controls.Add(lbl_np_status);
            Controls.Add(lbl_np_niveldeluz);
            Controls.Add(lbl_np_temperatura);
            Controls.Add(lbl_np_umidade);
            Controls.Add(combobox_np_medidadetempo);
            Controls.Add(combobox_np_classe);
            Controls.Add(txtbox_np_tempomedio);
            Controls.Add(lbl_medida_tempo);
            Controls.Add(lbl_np_tempo_maturacao);
            Controls.Add(lbl_np_classe);
            Controls.Add(lbl_np_nomedoproduto);
            Controls.Add(lbl_dadosdaproducao);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(lbl_novaproducao);
            Controls.Add(pictureBox2);
            Name = "TelaNovaProducao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaNovaProducao_FormClosing;
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
        private Label lbl_dadosdaproducao;
        private Label lbl_np_nomedoproduto;
        private Label lbl_np_classe;
        private Label lbl_np_tempo_maturacao;
        private Label lbl_medida_tempo;
        private Label lbl_np_umidade;
        private Label lbl_np_temperatura;
        private Label lbl_np_niveldeluz;
        private Label lbl_np_status;
        private Button btn_np_voltar;
        private Label lbl_np_data;
        private Label lbl_cod_np;
        public TextBox txtbox_np_codigoprod;
        public TextBox txtbox_np_nomedoproduto;
        public ComboBox combobox_np_classe;
        public ComboBox combobox_np_medidadetempo;
        public TextBox txtbox_np_tempomedio;
        public TextBox txtbox_np_umidade;
        public TextBox txtbox_np_temperatura;
        public TextBox txtbox_np_niveldeluz;
        public DateTimePicker dateTimePicker1;
        public RadioButton rb_np_status_ativo;
        public RadioButton rb_np_status_inativo;
        public Button btn_np_salvar;
        public Label lbl_novaproducao;
    }
}