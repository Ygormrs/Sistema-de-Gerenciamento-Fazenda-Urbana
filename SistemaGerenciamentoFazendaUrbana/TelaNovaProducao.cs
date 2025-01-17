using System;
using System.Collections;
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
    public partial class TelaNovaProducao : Form
    {
        public TelaNovaProducao()
        {
            InitializeComponent();
        }


        private void btn_np_salvar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn; // Associar conexão ao comando
            cmd.CommandText = "INSERT INTO Producoes(Nome, Classe, TempoMedioMaturacao, MedidaTempo, Umidade, Temperatura, NivelLuz, StatusProducao, DataProducao) VALUES(@nome, @classe, @tempodematuracao, @medidatempo, @umidade, @temperatura, @nivelluz, @status, @dataproducao)";

            // Adicionar parâmetros ao comando
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtbox_np_nomedoproduto.Text;
            cmd.Parameters.Add("@classe", SqlDbType.VarChar).Value = combobox_np_classe.Text;
            cmd.Parameters.Add("@tempodematuracao", SqlDbType.Int).Value = int.TryParse(txtbox_np_tempomedio.Text, out int tempoDeMaturacao) ? tempoDeMaturacao : 0;
            cmd.Parameters.Add("@medidatempo", SqlDbType.VarChar).Value = combobox_np_medidadetempo.Text;
            cmd.Parameters.Add("@umidade", SqlDbType.Decimal).Value = decimal.TryParse(txtbox_np_umidade.Text, out decimal umidade) ? umidade : 0;
            cmd.Parameters.Add("@temperatura", SqlDbType.Decimal).Value = decimal.TryParse(txtbox_np_temperatura.Text, out decimal temperatura) ? temperatura : 0;
            cmd.Parameters.Add("@nivelluz", SqlDbType.Decimal).Value = decimal.TryParse(txtbox_np_niveldeluz.Text, out decimal nivelLuz) ? nivelLuz : 0;
            cmd.Parameters.Add("@dataproducao", SqlDbType.Date).Value = dateTimePicker1.Text;

            if (rb_np_status_ativo.Checked == true)
            {
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = rb_np_status_ativo.Text;
            }
            else
            {
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = rb_np_status_inativo.Text;
            }

            try
            {
                cn.Open(); // Abre a conexão
                cmd.ExecuteNonQuery(); // Executa o comando

                cmd.CommandText = "SELECT @@IDENTITY";
                txtbox_np_codigoprod.Text = cmd.ExecuteScalar().ToString();

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

        private void btn_np_voltar_Click(object sender, EventArgs e)
        {
            // Chama o método de confirmação
            if (ConfirmarVoltar())
            {
                this.Hide(); // Oculta a tela atual
            }
        }

        private bool ConfirmarVoltar()
        {
            var resultado = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado == DialogResult.Yes; // Retorna true se o usuário clicar em "Sim"
        }

        private void TelaNovaProducao_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
