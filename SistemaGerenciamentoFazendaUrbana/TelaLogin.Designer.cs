namespace SistemaGerenciamentoFazendaUrbana
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtbox_CodLogin = new TextBox();
            btn_Login_Entrar = new Button();
            button1 = new Button();
            txtbox_LoginSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.BackgroundImage = Properties.Resources.LogoNexus;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(479, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 99);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(379, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 407);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(404, 326);
            label1.Name = "label1";
            label1.Size = new Size(241, 32);
            label1.TabIndex = 2;
            label1.Text = "Entrar na Sua Conta";
            // 
            // txtbox_CodLogin
            // 
            txtbox_CodLogin.ForeColor = Color.DarkGray;
            txtbox_CodLogin.Location = new Point(404, 380);
            txtbox_CodLogin.Name = "txtbox_CodLogin";
            txtbox_CodLogin.PlaceholderText = "Código de Login";
            txtbox_CodLogin.Size = new Size(241, 23);
            txtbox_CodLogin.TabIndex = 3;
            txtbox_CodLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Login_Entrar
            // 
            btn_Login_Entrar.BackColor = Color.Green;
            btn_Login_Entrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login_Entrar.ForeColor = Color.White;
            btn_Login_Entrar.Location = new Point(404, 452);
            btn_Login_Entrar.Name = "btn_Login_Entrar";
            btn_Login_Entrar.Size = new Size(241, 29);
            btn_Login_Entrar.TabIndex = 5;
            btn_Login_Entrar.Text = "ENTRAR";
            btn_Login_Entrar.UseVisualStyleBackColor = false;
            btn_Login_Entrar.Click += btn_Login_Entrar_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(470, 497);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 6;
            button1.Text = "Como acessar?";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtbox_LoginSenha
            // 
            txtbox_LoginSenha.ForeColor = Color.DarkGray;
            txtbox_LoginSenha.Location = new Point(404, 409);
            txtbox_LoginSenha.Name = "txtbox_LoginSenha";
            txtbox_LoginSenha.PlaceholderText = "Senha";
            txtbox_LoginSenha.Size = new Size(241, 23);
            txtbox_LoginSenha.TabIndex = 4;
            txtbox_LoginSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login;
            ClientSize = new Size(1008, 681);
            Controls.Add(txtbox_LoginSenha);
            Controls.Add(button1);
            Controls.Add(btn_Login_Entrar);
            Controls.Add(txtbox_CodLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus Urban Farm";
            FormClosing += Login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtbox_CodLogin;
        private Button btn_Login_Entrar;
        private Button button1;
        private TextBox txtbox_LoginSenha;
    }
}
