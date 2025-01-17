namespace SistemaGerenciamentoFazendaUrbana
{
    partial class TelaUsuario
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
            btn_usuario_sair = new Button();
            btn_editarperfil = new Button();
            btn_visualizargrupo = new Button();
            btn_visualizarperfil = new Button();
            SuspendLayout();
            // 
            // btn_usuario_sair
            // 
            btn_usuario_sair.Location = new Point(130, 347);
            btn_usuario_sair.Name = "btn_usuario_sair";
            btn_usuario_sair.Size = new Size(75, 23);
            btn_usuario_sair.TabIndex = 0;
            btn_usuario_sair.Text = "Sair";
            btn_usuario_sair.UseVisualStyleBackColor = true;
            // 
            // btn_editarperfil
            // 
            btn_editarperfil.ForeColor = Color.Green;
            btn_editarperfil.Location = new Point(130, 245);
            btn_editarperfil.Name = "btn_editarperfil";
            btn_editarperfil.Size = new Size(75, 23);
            btn_editarperfil.TabIndex = 1;
            btn_editarperfil.Text = "Editar Perfil";
            btn_editarperfil.UseVisualStyleBackColor = true;
            // 
            // btn_visualizargrupo
            // 
            btn_visualizargrupo.ForeColor = Color.Green;
            btn_visualizargrupo.Location = new Point(107, 197);
            btn_visualizargrupo.Name = "btn_visualizargrupo";
            btn_visualizargrupo.Size = new Size(122, 23);
            btn_visualizargrupo.TabIndex = 2;
            btn_visualizargrupo.Text = "Visualizar Grupo";
            btn_visualizargrupo.UseVisualStyleBackColor = true;
            // 
            // btn_visualizarperfil
            // 
            btn_visualizarperfil.ForeColor = Color.Green;
            btn_visualizarperfil.Location = new Point(120, 152);
            btn_visualizarperfil.Name = "btn_visualizarperfil";
            btn_visualizarperfil.Size = new Size(99, 23);
            btn_visualizarperfil.TabIndex = 3;
            btn_visualizarperfil.Text = "Visualizar Perfil";
            btn_visualizarperfil.UseVisualStyleBackColor = true;
            // 
            // TelaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(334, 411);
            Controls.Add(btn_visualizarperfil);
            Controls.Add(btn_visualizargrupo);
            Controls.Add(btn_editarperfil);
            Controls.Add(btn_usuario_sair);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            FormClosing += TelaUsuario_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_usuario_sair;
        private Button btn_editarperfil;
        private Button btn_visualizargrupo;
        private Button btn_visualizarperfil;
    }
}