namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaNovaEquipe
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
            lbl_novaequipe = new Label();
            pictureBox1_novaequipe = new PictureBox();
            lbl_dadosdaequipe = new Label();
            lbl_ne_nomequipe = new Label();
            txtbox_ne_nomeequipe = new TextBox();
            lbl_ne_emaildolider = new Label();
            txtbox_ne_emaildolider = new TextBox();
            btn_ne_salvar = new Button();
            btn_ne_voltar = new Button();
            txtbox_codigo_equipe = new TextBox();
            lbl_codigo_equipe = new Label();
            btn_att_ne = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_novaequipe).BeginInit();
            SuspendLayout();
            // 
            // lbl_novaequipe
            // 
            lbl_novaequipe.AutoSize = true;
            lbl_novaequipe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_novaequipe.Location = new Point(133, 25);
            lbl_novaequipe.Name = "lbl_novaequipe";
            lbl_novaequipe.Size = new Size(125, 25);
            lbl_novaequipe.TabIndex = 86;
            lbl_novaequipe.Text = "Nova Equipe";
            // 
            // pictureBox1_novaequipe
            // 
            pictureBox1_novaequipe.BackColor = Color.White;
            pictureBox1_novaequipe.Location = new Point(12, 53);
            pictureBox1_novaequipe.Name = "pictureBox1_novaequipe";
            pictureBox1_novaequipe.Size = new Size(360, 454);
            pictureBox1_novaequipe.TabIndex = 87;
            pictureBox1_novaequipe.TabStop = false;
            // 
            // lbl_dadosdaequipe
            // 
            lbl_dadosdaequipe.AutoSize = true;
            lbl_dadosdaequipe.BackColor = Color.White;
            lbl_dadosdaequipe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dadosdaequipe.ForeColor = Color.Green;
            lbl_dadosdaequipe.Location = new Point(28, 75);
            lbl_dadosdaequipe.Name = "lbl_dadosdaequipe";
            lbl_dadosdaequipe.Size = new Size(138, 21);
            lbl_dadosdaequipe.TabIndex = 88;
            lbl_dadosdaequipe.Text = "Dados da Equipe";
            // 
            // lbl_ne_nomequipe
            // 
            lbl_ne_nomequipe.AutoSize = true;
            lbl_ne_nomequipe.BackColor = Color.White;
            lbl_ne_nomequipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ne_nomequipe.ForeColor = SystemColors.ControlDarkDark;
            lbl_ne_nomequipe.Location = new Point(28, 118);
            lbl_ne_nomequipe.Name = "lbl_ne_nomequipe";
            lbl_ne_nomequipe.Size = new Size(97, 15);
            lbl_ne_nomequipe.TabIndex = 89;
            lbl_ne_nomequipe.Text = "Nome da Equipe";
            // 
            // txtbox_ne_nomeequipe
            // 
            txtbox_ne_nomeequipe.Location = new Point(28, 136);
            txtbox_ne_nomeequipe.Name = "txtbox_ne_nomeequipe";
            txtbox_ne_nomeequipe.Size = new Size(329, 23);
            txtbox_ne_nomeequipe.TabIndex = 92;
            // 
            // lbl_ne_emaildolider
            // 
            lbl_ne_emaildolider.AutoSize = true;
            lbl_ne_emaildolider.BackColor = Color.White;
            lbl_ne_emaildolider.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ne_emaildolider.ForeColor = SystemColors.ControlDarkDark;
            lbl_ne_emaildolider.Location = new Point(28, 197);
            lbl_ne_emaildolider.Name = "lbl_ne_emaildolider";
            lbl_ne_emaildolider.Size = new Size(89, 15);
            lbl_ne_emaildolider.TabIndex = 93;
            lbl_ne_emaildolider.Text = "E-mail do Líder";
            // 
            // txtbox_ne_emaildolider
            // 
            txtbox_ne_emaildolider.Location = new Point(28, 215);
            txtbox_ne_emaildolider.Name = "txtbox_ne_emaildolider";
            txtbox_ne_emaildolider.Size = new Size(329, 23);
            txtbox_ne_emaildolider.TabIndex = 94;
            // 
            // btn_ne_salvar
            // 
            btn_ne_salvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ne_salvar.Location = new Point(282, 526);
            btn_ne_salvar.Name = "btn_ne_salvar";
            btn_ne_salvar.Size = new Size(75, 23);
            btn_ne_salvar.TabIndex = 96;
            btn_ne_salvar.Text = "Salvar";
            btn_ne_salvar.UseVisualStyleBackColor = true;
            btn_ne_salvar.Click += btn_ne_salvar_Click;
            // 
            // btn_ne_voltar
            // 
            btn_ne_voltar.BackColor = Color.Red;
            btn_ne_voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ne_voltar.ForeColor = SystemColors.Control;
            btn_ne_voltar.Location = new Point(28, 526);
            btn_ne_voltar.Name = "btn_ne_voltar";
            btn_ne_voltar.Size = new Size(75, 23);
            btn_ne_voltar.TabIndex = 95;
            btn_ne_voltar.Text = "Voltar";
            btn_ne_voltar.UseVisualStyleBackColor = false;
            btn_ne_voltar.Click += btn_ne_voltar_Click;
            // 
            // txtbox_codigo_equipe
            // 
            txtbox_codigo_equipe.Location = new Point(282, 77);
            txtbox_codigo_equipe.Name = "txtbox_codigo_equipe";
            txtbox_codigo_equipe.ReadOnly = true;
            txtbox_codigo_equipe.Size = new Size(75, 23);
            txtbox_codigo_equipe.TabIndex = 97;
            // 
            // lbl_codigo_equipe
            // 
            lbl_codigo_equipe.AutoSize = true;
            lbl_codigo_equipe.BackColor = Color.White;
            lbl_codigo_equipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_codigo_equipe.ForeColor = SystemColors.ControlDarkDark;
            lbl_codigo_equipe.Location = new Point(231, 81);
            lbl_codigo_equipe.Name = "lbl_codigo_equipe";
            lbl_codigo_equipe.Size = new Size(45, 15);
            lbl_codigo_equipe.TabIndex = 98;
            lbl_codigo_equipe.Text = "Código";
            // 
            // btn_att_ne
            // 
            btn_att_ne.BackColor = Color.YellowGreen;
            btn_att_ne.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_att_ne.Location = new Point(152, 526);
            btn_att_ne.Name = "btn_att_ne";
            btn_att_ne.Size = new Size(75, 23);
            btn_att_ne.TabIndex = 157;
            btn_att_ne.Text = "Atualizar";
            btn_att_ne.UseVisualStyleBackColor = false;
            btn_att_ne.Click += btn_att_ne_Click;
            // 
            // TelaNovaEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(btn_att_ne);
            Controls.Add(lbl_codigo_equipe);
            Controls.Add(txtbox_codigo_equipe);
            Controls.Add(btn_ne_salvar);
            Controls.Add(btn_ne_voltar);
            Controls.Add(txtbox_ne_emaildolider);
            Controls.Add(lbl_ne_emaildolider);
            Controls.Add(txtbox_ne_nomeequipe);
            Controls.Add(lbl_ne_nomequipe);
            Controls.Add(lbl_dadosdaequipe);
            Controls.Add(pictureBox1_novaequipe);
            Controls.Add(lbl_novaequipe);
            MaximizeBox = false;
            Name = "TelaNovaEquipe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            //FormClosing += TelaNovaEquipe_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1_novaequipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1_novaequipe;
        private Label lbl_dadosdaequipe;
        private Label lbl_ne_nomequipe;
        private Label lbl_ne_emaildolider;
        public TextBox txtbox_codigo_equipe;
        private Label lbl_codigo_equipe;
        public Label lbl_novaequipe;
        public TextBox txtbox_ne_nomeequipe;
        public TextBox txtbox_ne_emaildolider;
        public Button btn_ne_salvar;
        public Button btn_ne_voltar;
        public Button btn_att_ne;
    }
}