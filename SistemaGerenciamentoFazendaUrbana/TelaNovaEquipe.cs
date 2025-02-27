using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGerenciamentoFazendaUrbana
{
    public partial class TelaNovaEquipe : Form
    {
        public TelaNovaEquipe()
        {
            InitializeComponent();
        }

        private void btn_ne_salvar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn; // Associar conexão ao comando
            cmd.CommandText = "INSERT INTO Equipes(Nome, Email) VALUES(@nome, @email)";

            // Adicionar parâmetros ao comando
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtbox_ne_nomeequipe.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtbox_ne_emaildolider.Text;

            try
            {
                cn.Open(); // Abre a conexão
                cmd.ExecuteNonQuery(); // Executa o comando

                cmd.CommandText = "SELECT @@IDENTITY";
                txtbox_codigo_equipe.Text = cmd.ExecuteScalar().ToString();

                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}");
            }
            finally
            {
                cn.Close(); // Fecha a conexão
                this.Hide();
            }
        }

        private void btn_ne_voltar_Click(object sender, EventArgs e)
        {
            // Chama o método de confirmação
            if (ConfirmarVoltar())
            {
                // Código para voltar à tela anterior
                this.Hide(); // Oculta a tela atual
            }
        }

        private bool ConfirmarVoltar()
        {
            var resultado = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado == DialogResult.Yes; // Retorna true se o usuário clicar em "Sim"
        }

        //private void TelaNovaEquipe_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (dlg == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void btn_att_ne_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn; // Associar conexão ao comando

            // Alteração do comando SQL para UPDATE
            cmd.CommandText = "UPDATE Equipes SET " +
                              "Nome = @nome, " +
                              "Email = @email " +
                              "WHERE IDEquipe = @codigo"; // Supondo que você use o "Codigo" como chave primária

            // Adicionar parâmetros ao comando
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtbox_ne_nomeequipe.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtbox_ne_emaildolider.Text;

            // Supondo que o código do produto esteja no TextBox `txtbox_nf_codigo`
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = int.TryParse(txtbox_codigo_equipe.Text, out int codigo) ? codigo : 0;

            //if (rb_nc_status_ativo.Checked == true)
            //{
            //    cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = rb_nc_status_ativo.Text;
            //}
            //else
            //{
            //    cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = rb_nc_status_inativo.Text;
            //}

            try
            {
                cn.Open(); // Abre a conexão
                cmd.ExecuteNonQuery(); // Executa o comando de atualização

                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar os dados: {ex.Message}");
            }
            finally
            {
                cn.Close(); // Fecha a conexão
                this.Hide();
            }
        }
    }
}
