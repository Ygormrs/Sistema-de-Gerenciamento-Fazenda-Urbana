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
    public partial class TelaFornecedores : Form
    {
        public TelaFornecedores()
        {
            InitializeComponent();
        }

        private void btn_add_fornecedor_Click(object sender, EventArgs e)
        {
            TelaNovoFornecedor FormMain = new TelaNovoFornecedor();
            FormMain.ShowDialog();
        }

        private void btn_fornecedores_voltar_Click(object sender, EventArgs e)
        {
            TelaMenu FormMain = new TelaMenu();
            this.Hide();

        }

        private void TelaFornecedores_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus"))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Fornecedores", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btn_fornecedor_consulta_Click(object sender, EventArgs e)
        {

            TelaNovoFornecedor FormMain = new TelaNovoFornecedor();
            FormMain.btn_nf_salvar.Visible = false;
            FormMain.txtbox_nf_codigo.Text = dataGridView1.CurrentRow.Cells["IDFornecedor"].Value.ToString();
            FormMain.msktxtbox_nf_cnpj.Enabled = false;
            FormMain.msktxtbox_nf_cnpj.Text = dataGridView1.CurrentRow.Cells["CNPJ"].Value.ToString();
            FormMain.txtbox_nf_razaosocial.Enabled = false;
            FormMain.txtbox_nf_razaosocial.Text = dataGridView1.CurrentRow.Cells["RazaoSocial"].Value.ToString();
            FormMain.txtbox_nf_nomefantasia.Enabled = false;
            FormMain.txtbox_nf_nomefantasia.Text = dataGridView1.CurrentRow.Cells["NomeFantasia"].Value.ToString();
            FormMain.msktxtbox_nf_cep.Enabled = false;
            FormMain.msktxtbox_nf_cep.Text = dataGridView1.CurrentRow.Cells["CEP"].Value.ToString();
            FormMain.combobox_nf_estado.Enabled = false;
            FormMain.combobox_nf_estado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
            FormMain.txtbox_nf_cidade.Enabled = false;
            FormMain.txtbox_nf_cidade.Text = dataGridView1.CurrentRow.Cells["Cidade"].Value.ToString();
            FormMain.txtbox_nf_bairro.Enabled = false;
            FormMain.txtbox_nf_bairro.Text = dataGridView1.CurrentRow.Cells["Bairro"].Value.ToString();
            FormMain.txtbox_nf_rua.Enabled = false;
            FormMain.txtbox_nf_rua.Text = dataGridView1.CurrentRow.Cells["Rua"].Value.ToString();
            FormMain.txtbox_nf_numero.Enabled = false;
            FormMain.txtbox_nf_numero.Text = dataGridView1.CurrentRow.Cells["Numero"].Value.ToString();
            FormMain.txtbox_nf_complemento.Enabled = false;
            FormMain.txtbox_nf_complemento.Text = dataGridView1.CurrentRow.Cells["Complemento"].Value.ToString();
            FormMain.msktxtbox_nf_telefone.Enabled = false;
            FormMain.msktxtbox_nf_telefone.Text = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
            FormMain.txtbox_nf_email.Enabled = false;
            FormMain.txtbox_nf_email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            FormMain.txtbox_nf_nomerepresentante.Enabled = false;
            FormMain.txtbox_nf_nomerepresentante.Text = dataGridView1.CurrentRow.Cells["NomeRepresentante"].Value.ToString();
            FormMain.rb_nf_status_ativo.Enabled = false;
            FormMain.rb_nf_status_inativo.Enabled = false;
            if (FormMain.rb_nf_status_ativo.Checked == true)
            {
                FormMain.rb_nf_status_ativo.Text = dataGridView1.CurrentRow.Cells["StatusFornecedor"].Value.ToString();
            }
            else
            {
                FormMain.rb_nf_status_inativo.Text = dataGridView1.CurrentRow.Cells["StatusFornecedor"].Value.ToString();
            }
            FormMain.ShowDialog();
        }

        private void TelaFornecedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
