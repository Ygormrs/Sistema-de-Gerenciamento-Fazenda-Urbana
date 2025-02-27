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
    public partial class TelaClientes : Form
    {
        public TelaClientes()
        {
            InitializeComponent();
        }

        private void btn_clientes_voltar_Click(object sender, EventArgs e)
        {
            TelaMenu FormMain = new TelaMenu();
            this.Hide();
        }

        private void btn_add_cliente_Click(object sender, EventArgs e)
        {
            TelaNovoCliente FormMain = new TelaNovoCliente();
            FormMain.btn_att_nc.Visible = false;
            FormMain.ShowDialog();
        }

        private void TelaClientes_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus"))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btn_consultar_cliente_Click(object sender, EventArgs e)
        {

            TelaNovoCliente FormMain = new TelaNovoCliente();
            FormMain.lbl_novocliente.Text = "Consulta Cliente";
            FormMain.btn_nc_salvar.Visible = false;
            FormMain.btn_att_nc.Visible = false;
            FormMain.txtbox_nc_codigo.Text = dataGridView1.CurrentRow.Cells["IDCliente"].Value.ToString();
            FormMain.msktxtbox_nc_cnpj.Enabled = false;
            FormMain.msktxtbox_nc_cnpj.Text = dataGridView1.CurrentRow.Cells["CNPJ"].Value.ToString();
            FormMain.txtbox_nc_razaosocial.Enabled = false;
            FormMain.txtbox_nc_razaosocial.Text = dataGridView1.CurrentRow.Cells["RazaoSocial"].Value.ToString();
            FormMain.txtbox_nc_nomefantasia.Enabled = false;
            FormMain.txtbox_nc_nomefantasia.Text = dataGridView1.CurrentRow.Cells["NomeFantasia"].Value.ToString();
            FormMain.msktxtbox_nc_cep.Enabled = false;
            FormMain.msktxtbox_nc_cep.Text = dataGridView1.CurrentRow.Cells["CEP"].Value.ToString();
            FormMain.combobox_nc_estado.Enabled = false;
            FormMain.combobox_nc_estado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
            FormMain.txtbox_nc_cidade.Enabled = false;
            FormMain.txtbox_nc_cidade.Text = dataGridView1.CurrentRow.Cells["Cidade"].Value.ToString();
            FormMain.txtbox_nc_bairro.Enabled = false;
            FormMain.txtbox_nc_bairro.Text = dataGridView1.CurrentRow.Cells["Bairro"].Value.ToString();
            FormMain.txtbox_nc_rua.Enabled = false;
            FormMain.txtbox_nc_rua.Text = dataGridView1.CurrentRow.Cells["Rua"].Value.ToString();
            FormMain.txtbox_nc_numero.Enabled = false;
            FormMain.txtbox_nc_numero.Text = dataGridView1.CurrentRow.Cells["Numero"].Value.ToString();
            FormMain.txtbox_nc_complemento.Enabled = false;
            FormMain.txtbox_nc_complemento.Text = dataGridView1.CurrentRow.Cells["Complemento"].Value.ToString();
            FormMain.msktxtbox_nc_telefone.Enabled = false;
            FormMain.msktxtbox_nc_telefone.Text = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
            FormMain.txtbox_nc_email.Enabled = false;
            FormMain.txtbox_nc_email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            FormMain.txtbox_nc_nomerepresentante.Enabled = false;
            FormMain.txtbox_nc_nomerepresentante.Text = dataGridView1.CurrentRow.Cells["NomeRepresentante"].Value.ToString();
            FormMain.rb_nc_status_ativo.Enabled = false;
            FormMain.rb_nc_status_inativo.Enabled = false;
            if (FormMain.rb_nc_status_ativo.Checked == true)
            {
                FormMain.rb_nc_status_ativo.Text = dataGridView1.CurrentRow.Cells["StatusCliente"].Value.ToString();
            }
            else
            {
                FormMain.rb_nc_status_inativo.Text = dataGridView1.CurrentRow.Cells["StatusCliente"].Value.ToString();
            }
            FormMain.ShowDialog();
        }

        private void TelaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_editar_cliente_Click(object sender, EventArgs e)
        {

            TelaNovoCliente FormMain = new TelaNovoCliente();
            FormMain.lbl_novocliente.Text = "Editar Cliente";
            FormMain.btn_nc_salvar.Visible = false;
            FormMain.txtbox_nc_codigo.Text = dataGridView1.CurrentRow.Cells["IDCliente"].Value.ToString();
            FormMain.msktxtbox_nc_cnpj.Text = dataGridView1.CurrentRow.Cells["CNPJ"].Value.ToString();
            FormMain.txtbox_nc_razaosocial.Text = dataGridView1.CurrentRow.Cells["RazaoSocial"].Value.ToString();
            FormMain.txtbox_nc_nomefantasia.Text = dataGridView1.CurrentRow.Cells["NomeFantasia"].Value.ToString();
            FormMain.msktxtbox_nc_cep.Text = dataGridView1.CurrentRow.Cells["CEP"].Value.ToString();
            FormMain.combobox_nc_estado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
            FormMain.txtbox_nc_cidade.Text = dataGridView1.CurrentRow.Cells["Cidade"].Value.ToString();
            FormMain.txtbox_nc_bairro.Text = dataGridView1.CurrentRow.Cells["Bairro"].Value.ToString();
            FormMain.txtbox_nc_rua.Text = dataGridView1.CurrentRow.Cells["Rua"].Value.ToString();
            FormMain.txtbox_nc_numero.Text = dataGridView1.CurrentRow.Cells["Numero"].Value.ToString();
            FormMain.txtbox_nc_complemento.Text = dataGridView1.CurrentRow.Cells["Complemento"].Value.ToString();
            FormMain.msktxtbox_nc_telefone.Text = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
            FormMain.txtbox_nc_email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            FormMain.txtbox_nc_nomerepresentante.Text = dataGridView1.CurrentRow.Cells["NomeRepresentante"].Value.ToString();

            if (FormMain.rb_nc_status_ativo.Checked == true)
            {
                FormMain.rb_nc_status_ativo.Text = dataGridView1.CurrentRow.Cells["StatusCliente"].Value.ToString();
            }
            else
            {
                FormMain.rb_nc_status_inativo.Text = dataGridView1.CurrentRow.Cells["StatusCliente"].Value.ToString();
            }
            FormMain.ShowDialog();
        }
    }
}
