namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaNovoCliente
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
            msktxtbox_nc_telefone = new MaskedTextBox();
            msktxtbox_nc_cep = new MaskedTextBox();
            btn_nc_salvar = new Button();
            btn_nc_voltar = new Button();
            txtbox_nc_nomerepresentante = new TextBox();
            txtbox_nc_email = new TextBox();
            lbl_nc_email = new Label();
            lbl_nc_nomerepresentante = new Label();
            lbl_nc_telefone = new Label();
            lbl_nc_contato = new Label();
            lbl_nc_complemento = new Label();
            txtbox_nc_complemento = new TextBox();
            lbl_nc_numero = new Label();
            txtbox_nc_numero = new TextBox();
            txtbox_nc_rua = new TextBox();
            lbl_nc_rua = new Label();
            lbl_nc_bairro = new Label();
            txtbox_nc_bairro = new TextBox();
            lbl_nc_cidade = new Label();
            txtbox_nc_cidade = new TextBox();
            combobox_nc_estado = new ComboBox();
            lbl_nc_estado = new Label();
            lbl_nf_cep = new Label();
            lbl_nc_endereco = new Label();
            lbl_nc_nomefantasia = new Label();
            txtbox_nc_nomefantasia = new TextBox();
            lbl_nc_razaosocial = new Label();
            txtbox_nc_razaosocial = new TextBox();
            lbl_nc_status = new Label();
            lbl_nc_cpf_cnpj = new Label();
            lbl_dadosdocliente = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            lbl_novocliente = new Label();
            pictureBox2 = new PictureBox();
            rb_nc_status_ativo = new RadioButton();
            rb_nc_status_inativo = new RadioButton();
            msktxtbox_nc_cnpj = new MaskedTextBox();
            txtbox_nc_codigo = new TextBox();
            lbl_nc_codigo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // msktxtbox_nc_telefone
            // 
            msktxtbox_nc_telefone.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            msktxtbox_nc_telefone.Location = new Point(42, 506);
            msktxtbox_nc_telefone.Mask = "(00)000000000";
            msktxtbox_nc_telefone.Name = "msktxtbox_nc_telefone";
            msktxtbox_nc_telefone.Size = new Size(176, 23);
            msktxtbox_nc_telefone.TabIndex = 12;
            // 
            // msktxtbox_nc_cep
            // 
            msktxtbox_nc_cep.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            msktxtbox_nc_cep.Location = new Point(42, 332);
            msktxtbox_nc_cep.Mask = "00,000-000";
            msktxtbox_nc_cep.Name = "msktxtbox_nc_cep";
            msktxtbox_nc_cep.Size = new Size(176, 23);
            msktxtbox_nc_cep.TabIndex = 5;
            // 
            // btn_nc_salvar
            // 
            btn_nc_salvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nc_salvar.Location = new Point(878, 622);
            btn_nc_salvar.Name = "btn_nc_salvar";
            btn_nc_salvar.Size = new Size(75, 23);
            btn_nc_salvar.TabIndex = 16;
            btn_nc_salvar.Text = "Salvar";
            btn_nc_salvar.UseVisualStyleBackColor = true;
            btn_nc_salvar.Click += btn_nc_salvar_Click;
            // 
            // btn_nc_voltar
            // 
            btn_nc_voltar.BackColor = Color.Red;
            btn_nc_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nc_voltar.ForeColor = SystemColors.Control;
            btn_nc_voltar.Location = new Point(42, 622);
            btn_nc_voltar.Name = "btn_nc_voltar";
            btn_nc_voltar.Size = new Size(75, 23);
            btn_nc_voltar.TabIndex = 15;
            btn_nc_voltar.Text = "Voltar";
            btn_nc_voltar.UseVisualStyleBackColor = false;
            btn_nc_voltar.Click += btn_nc_voltar_Click;
            // 
            // txtbox_nc_nomerepresentante
            // 
            txtbox_nc_nomerepresentante.Location = new Point(634, 506);
            txtbox_nc_nomerepresentante.Name = "txtbox_nc_nomerepresentante";
            txtbox_nc_nomerepresentante.Size = new Size(319, 23);
            txtbox_nc_nomerepresentante.TabIndex = 14;
            // 
            // txtbox_nc_email
            // 
            txtbox_nc_email.Location = new Point(257, 506);
            txtbox_nc_email.Name = "txtbox_nc_email";
            txtbox_nc_email.PlaceholderText = "example@example.com";
            txtbox_nc_email.Size = new Size(265, 23);
            txtbox_nc_email.TabIndex = 13;
            // 
            // lbl_nc_email
            // 
            lbl_nc_email.AutoSize = true;
            lbl_nc_email.BackColor = Color.White;
            lbl_nc_email.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_email.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_email.Location = new Point(257, 488);
            lbl_nc_email.Name = "lbl_nc_email";
            lbl_nc_email.Size = new Size(41, 15);
            lbl_nc_email.TabIndex = 112;
            lbl_nc_email.Text = "E-mail";
            // 
            // lbl_nc_nomerepresentante
            // 
            lbl_nc_nomerepresentante.AutoSize = true;
            lbl_nc_nomerepresentante.BackColor = Color.White;
            lbl_nc_nomerepresentante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_nomerepresentante.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_nomerepresentante.Location = new Point(634, 488);
            lbl_nc_nomerepresentante.Name = "lbl_nc_nomerepresentante";
            lbl_nc_nomerepresentante.Size = new Size(144, 15);
            lbl_nc_nomerepresentante.TabIndex = 111;
            lbl_nc_nomerepresentante.Text = "Nome do Representante";
            // 
            // lbl_nc_telefone
            // 
            lbl_nc_telefone.AutoSize = true;
            lbl_nc_telefone.BackColor = Color.White;
            lbl_nc_telefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_telefone.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_telefone.Location = new Point(42, 488);
            lbl_nc_telefone.Name = "lbl_nc_telefone";
            lbl_nc_telefone.Size = new Size(56, 15);
            lbl_nc_telefone.TabIndex = 110;
            lbl_nc_telefone.Text = "Telefone";
            // 
            // lbl_nc_contato
            // 
            lbl_nc_contato.AutoSize = true;
            lbl_nc_contato.BackColor = Color.White;
            lbl_nc_contato.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_contato.ForeColor = Color.Green;
            lbl_nc_contato.Location = new Point(42, 447);
            lbl_nc_contato.Name = "lbl_nc_contato";
            lbl_nc_contato.Size = new Size(71, 21);
            lbl_nc_contato.TabIndex = 109;
            lbl_nc_contato.Text = "Contato";
            // 
            // lbl_nc_complemento
            // 
            lbl_nc_complemento.AutoSize = true;
            lbl_nc_complemento.BackColor = Color.White;
            lbl_nc_complemento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_complemento.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_complemento.Location = new Point(687, 375);
            lbl_nc_complemento.Name = "lbl_nc_complemento";
            lbl_nc_complemento.Size = new Size(86, 15);
            lbl_nc_complemento.TabIndex = 108;
            lbl_nc_complemento.Text = "Complemento";
            // 
            // txtbox_nc_complemento
            // 
            txtbox_nc_complemento.Location = new Point(687, 393);
            txtbox_nc_complemento.Name = "txtbox_nc_complemento";
            txtbox_nc_complemento.Size = new Size(266, 23);
            txtbox_nc_complemento.TabIndex = 11;
            // 
            // lbl_nc_numero
            // 
            lbl_nc_numero.AutoSize = true;
            lbl_nc_numero.BackColor = Color.White;
            lbl_nc_numero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_numero.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_numero.Location = new Point(549, 375);
            lbl_nc_numero.Name = "lbl_nc_numero";
            lbl_nc_numero.Size = new Size(53, 15);
            lbl_nc_numero.TabIndex = 106;
            lbl_nc_numero.Text = "Numero";
            // 
            // txtbox_nc_numero
            // 
            txtbox_nc_numero.Location = new Point(549, 393);
            txtbox_nc_numero.Name = "txtbox_nc_numero";
            txtbox_nc_numero.PlaceholderText = "Digite o Numero";
            txtbox_nc_numero.Size = new Size(107, 23);
            txtbox_nc_numero.TabIndex = 10;
            // 
            // txtbox_nc_rua
            // 
            txtbox_nc_rua.Location = new Point(257, 393);
            txtbox_nc_rua.Name = "txtbox_nc_rua";
            txtbox_nc_rua.PlaceholderText = "Digite a Rua";
            txtbox_nc_rua.Size = new Size(265, 23);
            txtbox_nc_rua.TabIndex = 9;
            // 
            // lbl_nc_rua
            // 
            lbl_nc_rua.AutoSize = true;
            lbl_nc_rua.BackColor = Color.White;
            lbl_nc_rua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_rua.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_rua.Location = new Point(257, 375);
            lbl_nc_rua.Name = "lbl_nc_rua";
            lbl_nc_rua.Size = new Size(28, 15);
            lbl_nc_rua.TabIndex = 103;
            lbl_nc_rua.Text = "Rua";
            // 
            // lbl_nc_bairro
            // 
            lbl_nc_bairro.AutoSize = true;
            lbl_nc_bairro.BackColor = Color.White;
            lbl_nc_bairro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_bairro.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_bairro.Location = new Point(42, 375);
            lbl_nc_bairro.Name = "lbl_nc_bairro";
            lbl_nc_bairro.Size = new Size(41, 15);
            lbl_nc_bairro.TabIndex = 102;
            lbl_nc_bairro.Text = "Bairro";
            // 
            // txtbox_nc_bairro
            // 
            txtbox_nc_bairro.Location = new Point(42, 393);
            txtbox_nc_bairro.Name = "txtbox_nc_bairro";
            txtbox_nc_bairro.PlaceholderText = "Digite o Bairro";
            txtbox_nc_bairro.Size = new Size(176, 23);
            txtbox_nc_bairro.TabIndex = 8;
            // 
            // lbl_nc_cidade
            // 
            lbl_nc_cidade.AutoSize = true;
            lbl_nc_cidade.BackColor = Color.White;
            lbl_nc_cidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_cidade.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_cidade.Location = new Point(549, 314);
            lbl_nc_cidade.Name = "lbl_nc_cidade";
            lbl_nc_cidade.Size = new Size(44, 15);
            lbl_nc_cidade.TabIndex = 100;
            lbl_nc_cidade.Text = "Cidade";
            // 
            // txtbox_nc_cidade
            // 
            txtbox_nc_cidade.Location = new Point(549, 332);
            txtbox_nc_cidade.Name = "txtbox_nc_cidade";
            txtbox_nc_cidade.PlaceholderText = "Digite a Cidade";
            txtbox_nc_cidade.Size = new Size(404, 23);
            txtbox_nc_cidade.TabIndex = 7;
            // 
            // combobox_nc_estado
            // 
            combobox_nc_estado.FormattingEnabled = true;
            combobox_nc_estado.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            combobox_nc_estado.Location = new Point(257, 332);
            combobox_nc_estado.Name = "combobox_nc_estado";
            combobox_nc_estado.Size = new Size(189, 23);
            combobox_nc_estado.TabIndex = 6;
            // 
            // lbl_nc_estado
            // 
            lbl_nc_estado.AutoSize = true;
            lbl_nc_estado.BackColor = Color.White;
            lbl_nc_estado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_estado.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_estado.Location = new Point(257, 314);
            lbl_nc_estado.Name = "lbl_nc_estado";
            lbl_nc_estado.Size = new Size(43, 15);
            lbl_nc_estado.TabIndex = 97;
            lbl_nc_estado.Text = "Estado";
            // 
            // lbl_nf_cep
            // 
            lbl_nf_cep.AutoSize = true;
            lbl_nf_cep.BackColor = Color.White;
            lbl_nf_cep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nf_cep.ForeColor = SystemColors.ControlDarkDark;
            lbl_nf_cep.Location = new Point(42, 314);
            lbl_nf_cep.Name = "lbl_nf_cep";
            lbl_nf_cep.Size = new Size(27, 15);
            lbl_nf_cep.TabIndex = 96;
            lbl_nf_cep.Text = "CEP";
            // 
            // lbl_nc_endereco
            // 
            lbl_nc_endereco.AutoSize = true;
            lbl_nc_endereco.BackColor = Color.White;
            lbl_nc_endereco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_endereco.ForeColor = Color.Green;
            lbl_nc_endereco.Location = new Point(42, 267);
            lbl_nc_endereco.Name = "lbl_nc_endereco";
            lbl_nc_endereco.Size = new Size(81, 21);
            lbl_nc_endereco.TabIndex = 95;
            lbl_nc_endereco.Text = "Endereço";
            // 
            // lbl_nc_nomefantasia
            // 
            lbl_nc_nomefantasia.AutoSize = true;
            lbl_nc_nomefantasia.BackColor = Color.White;
            lbl_nc_nomefantasia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_nomefantasia.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_nomefantasia.Location = new Point(549, 196);
            lbl_nc_nomefantasia.Name = "lbl_nc_nomefantasia";
            lbl_nc_nomefantasia.Size = new Size(88, 15);
            lbl_nc_nomefantasia.TabIndex = 94;
            lbl_nc_nomefantasia.Text = "Nome Fantasia";
            // 
            // txtbox_nc_nomefantasia
            // 
            txtbox_nc_nomefantasia.Location = new Point(549, 216);
            txtbox_nc_nomefantasia.Name = "txtbox_nc_nomefantasia";
            txtbox_nc_nomefantasia.PlaceholderText = "Digite o Nome Fantasia";
            txtbox_nc_nomefantasia.Size = new Size(404, 23);
            txtbox_nc_nomefantasia.TabIndex = 4;
            // 
            // lbl_nc_razaosocial
            // 
            lbl_nc_razaosocial.AutoSize = true;
            lbl_nc_razaosocial.BackColor = Color.White;
            lbl_nc_razaosocial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_razaosocial.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_razaosocial.Location = new Point(42, 196);
            lbl_nc_razaosocial.Name = "lbl_nc_razaosocial";
            lbl_nc_razaosocial.Size = new Size(75, 15);
            lbl_nc_razaosocial.TabIndex = 92;
            lbl_nc_razaosocial.Text = "Razão Social";
            // 
            // txtbox_nc_razaosocial
            // 
            txtbox_nc_razaosocial.Location = new Point(42, 216);
            txtbox_nc_razaosocial.Name = "txtbox_nc_razaosocial";
            txtbox_nc_razaosocial.PlaceholderText = "Digite a Razão Social";
            txtbox_nc_razaosocial.Size = new Size(404, 23);
            txtbox_nc_razaosocial.TabIndex = 3;
            // 
            // lbl_nc_status
            // 
            lbl_nc_status.AutoSize = true;
            lbl_nc_status.BackColor = Color.White;
            lbl_nc_status.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_status.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_status.Location = new Point(549, 136);
            lbl_nc_status.Name = "lbl_nc_status";
            lbl_nc_status.Size = new Size(42, 15);
            lbl_nc_status.TabIndex = 90;
            lbl_nc_status.Text = "Status";
            // 
            // lbl_nc_cpf_cnpj
            // 
            lbl_nc_cpf_cnpj.AutoSize = true;
            lbl_nc_cpf_cnpj.BackColor = Color.White;
            lbl_nc_cpf_cnpj.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_cpf_cnpj.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_cpf_cnpj.Location = new Point(42, 136);
            lbl_nc_cpf_cnpj.Name = "lbl_nc_cpf_cnpj";
            lbl_nc_cpf_cnpj.Size = new Size(34, 15);
            lbl_nc_cpf_cnpj.TabIndex = 88;
            lbl_nc_cpf_cnpj.Text = "CNPJ";
            // 
            // lbl_dadosdocliente
            // 
            lbl_dadosdocliente.AutoSize = true;
            lbl_dadosdocliente.BackColor = Color.White;
            lbl_dadosdocliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dadosdocliente.ForeColor = Color.Green;
            lbl_dadosdocliente.Location = new Point(42, 90);
            lbl_dadosdocliente.Name = "lbl_dadosdocliente";
            lbl_dadosdocliente.Size = new Size(140, 21);
            lbl_dadosdocliente.TabIndex = 86;
            lbl_dadosdocliente.Text = "Dados do Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 516);
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.LogoNexus;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 84;
            pictureBox3.TabStop = false;
            // 
            // lbl_novocliente
            // 
            lbl_novocliente.AutoSize = true;
            lbl_novocliente.BackColor = Color.White;
            lbl_novocliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_novocliente.ForeColor = SystemColors.ControlDarkDark;
            lbl_novocliente.Location = new Point(56, 19);
            lbl_novocliente.Name = "lbl_novocliente";
            lbl_novocliente.Size = new Size(99, 20);
            lbl_novocliente.TabIndex = 83;
            lbl_novocliente.Text = "Novo Cliente";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1009, 47);
            pictureBox2.TabIndex = 82;
            pictureBox2.TabStop = false;
            // 
            // rb_nc_status_ativo
            // 
            rb_nc_status_ativo.AutoSize = true;
            rb_nc_status_ativo.BackColor = Color.White;
            rb_nc_status_ativo.Checked = true;
            rb_nc_status_ativo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_nc_status_ativo.ForeColor = SystemColors.ControlDarkDark;
            rb_nc_status_ativo.Location = new Point(549, 155);
            rb_nc_status_ativo.Name = "rb_nc_status_ativo";
            rb_nc_status_ativo.Size = new Size(55, 19);
            rb_nc_status_ativo.TabIndex = 1;
            rb_nc_status_ativo.TabStop = true;
            rb_nc_status_ativo.Text = "Ativo";
            rb_nc_status_ativo.UseVisualStyleBackColor = false;
            // 
            // rb_nc_status_inativo
            // 
            rb_nc_status_inativo.AutoSize = true;
            rb_nc_status_inativo.BackColor = Color.White;
            rb_nc_status_inativo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_nc_status_inativo.ForeColor = SystemColors.ControlDarkDark;
            rb_nc_status_inativo.Location = new Point(612, 155);
            rb_nc_status_inativo.Name = "rb_nc_status_inativo";
            rb_nc_status_inativo.Size = new Size(64, 19);
            rb_nc_status_inativo.TabIndex = 2;
            rb_nc_status_inativo.Text = "Inativo";
            rb_nc_status_inativo.UseVisualStyleBackColor = false;
            // 
            // msktxtbox_nc_cnpj
            // 
            msktxtbox_nc_cnpj.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            msktxtbox_nc_cnpj.Location = new Point(42, 151);
            msktxtbox_nc_cnpj.Mask = "00,000,000/0000-00";
            msktxtbox_nc_cnpj.Name = "msktxtbox_nc_cnpj";
            msktxtbox_nc_cnpj.Size = new Size(227, 23);
            msktxtbox_nc_cnpj.TabIndex = 0;
            // 
            // txtbox_nc_codigo
            // 
            txtbox_nc_codigo.Location = new Point(878, 92);
            txtbox_nc_codigo.Name = "txtbox_nc_codigo";
            txtbox_nc_codigo.ReadOnly = true;
            txtbox_nc_codigo.Size = new Size(75, 23);
            txtbox_nc_codigo.TabIndex = 113;
            // 
            // lbl_nc_codigo
            // 
            lbl_nc_codigo.AutoSize = true;
            lbl_nc_codigo.BackColor = Color.White;
            lbl_nc_codigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nc_codigo.ForeColor = SystemColors.ControlDarkDark;
            lbl_nc_codigo.Location = new Point(830, 96);
            lbl_nc_codigo.Name = "lbl_nc_codigo";
            lbl_nc_codigo.Size = new Size(45, 15);
            lbl_nc_codigo.TabIndex = 114;
            lbl_nc_codigo.Text = "Código";
            // 
            // TelaNovoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(lbl_nc_codigo);
            Controls.Add(txtbox_nc_codigo);
            Controls.Add(msktxtbox_nc_cnpj);
            Controls.Add(rb_nc_status_inativo);
            Controls.Add(rb_nc_status_ativo);
            Controls.Add(msktxtbox_nc_telefone);
            Controls.Add(msktxtbox_nc_cep);
            Controls.Add(btn_nc_salvar);
            Controls.Add(btn_nc_voltar);
            Controls.Add(txtbox_nc_nomerepresentante);
            Controls.Add(txtbox_nc_email);
            Controls.Add(lbl_nc_email);
            Controls.Add(lbl_nc_nomerepresentante);
            Controls.Add(lbl_nc_telefone);
            Controls.Add(lbl_nc_contato);
            Controls.Add(lbl_nc_complemento);
            Controls.Add(txtbox_nc_complemento);
            Controls.Add(lbl_nc_numero);
            Controls.Add(txtbox_nc_numero);
            Controls.Add(txtbox_nc_rua);
            Controls.Add(lbl_nc_rua);
            Controls.Add(lbl_nc_bairro);
            Controls.Add(txtbox_nc_bairro);
            Controls.Add(lbl_nc_cidade);
            Controls.Add(txtbox_nc_cidade);
            Controls.Add(combobox_nc_estado);
            Controls.Add(lbl_nc_estado);
            Controls.Add(lbl_nf_cep);
            Controls.Add(lbl_nc_endereco);
            Controls.Add(lbl_nc_nomefantasia);
            Controls.Add(txtbox_nc_nomefantasia);
            Controls.Add(lbl_nc_razaosocial);
            Controls.Add(txtbox_nc_razaosocial);
            Controls.Add(lbl_nc_status);
            Controls.Add(lbl_nc_cpf_cnpj);
            Controls.Add(lbl_dadosdocliente);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(lbl_novocliente);
            Controls.Add(pictureBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaNovoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += TelaNovoCliente_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_nc_email;
        private Label lbl_nc_nomerepresentante;
        private Label lbl_nc_telefone;
        private Label lbl_nc_contato;
        private Label lbl_nc_complemento;
        private Label lbl_nc_numero;
        private Label lbl_nc_rua;
        private Label lbl_nc_bairro;
        private Label lbl_nc_cidade;
        private Label lbl_nc_estado;
        private Label lbl_nf_cep;
        private Label lbl_nc_endereco;
        private Label lbl_nc_nomefantasia;
        private Label lbl_nc_razaosocial;
        private Label lbl_nc_status;
        private Label lbl_nc_cpf_cnpj;
        private Label lbl_dadosdocliente;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        public TextBox txtbox_nc_codigo;
        public Label lbl_nc_codigo;
        public MaskedTextBox msktxtbox_nc_telefone;
        public MaskedTextBox msktxtbox_nc_cep;
        public Button btn_nc_salvar;
        public Button btn_nc_voltar;
        public TextBox txtbox_nc_nomerepresentante;
        public TextBox txtbox_nc_email;
        public TextBox txtbox_nc_complemento;
        public TextBox txtbox_nc_numero;
        public TextBox txtbox_nc_rua;
        public TextBox txtbox_nc_bairro;
        public TextBox txtbox_nc_cidade;
        public ComboBox combobox_nc_estado;
        public TextBox txtbox_nc_nomefantasia;
        public TextBox txtbox_nc_razaosocial;
        public MaskedTextBox msktxtbox_nc_cnpj;
        public RadioButton rb_nc_status_ativo;
        public RadioButton rb_nc_status_inativo;
        public Label lbl_novocliente;
    }
}