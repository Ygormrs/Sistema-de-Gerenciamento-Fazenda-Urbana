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
    public partial class TelaFuncionarios : Form
    {
        public TelaFuncionarios()
        {
            InitializeComponent();
        }

        private void btn_add_funcionario_Click(object sender, EventArgs e)
        {
            TelaNovoFuncionario FormMain = new TelaNovoFuncionario();
            FormMain.btn_att_nfunc.Visible = false;
            FormMain.ShowDialog();
        }

        private void btn_funcionarios_voltar_Click(object sender, EventArgs e)
        {
            TelaMenu FormMain = new TelaMenu();
            this.Hide();
        }

        private void TelaFuncionarios_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus"))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Funcionarios", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btn_consultar_funcionario_Click(object sender, EventArgs e)
        {

            TelaNovoFuncionario FormMain = new TelaNovoFuncionario();
            FormMain.lbl_novofuncionario.Text = "Consulta Funcionário";
            FormMain.btn_nfunc_salvar.Visible = false;

            FormMain.txtbox_nfunc_codigo.Text = dataGridView1.CurrentRow.Cells["IDFuncionario"].Value.ToString();
            FormMain.txtbox_nfunc_codigo.Enabled = false;
            FormMain.msktxtbox_nfun_cpf.Text = dataGridView1.CurrentRow.Cells["CPF"].Value.ToString();
            FormMain.msktxtbox_nfun_cpf.Enabled = false;
            FormMain.txtbox_nfunc_nomecompleto.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            FormMain.txtbox_nfunc_nomecompleto.Enabled = false;
            FormMain.txtbox_nfunc_email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            FormMain.txtbox_nfunc_email.Enabled = false;
            FormMain.combobox_nfunc_equipe.Text = dataGridView1.CurrentRow.Cells["Equipe"].Value.ToString();
            FormMain.combobox_nfunc_equipe.Enabled = false;
            FormMain.ShowDialog();
        }

        private void TelaFuncionarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_editar_funcionario_Click(object sender, EventArgs e)
        {

            TelaNovoFuncionario FormMain = new TelaNovoFuncionario();
            FormMain.lbl_novofuncionario.Text = "Editar Funcionário";
            FormMain.txtbox_nfunc_codigo.Text = dataGridView1.CurrentRow.Cells["IDFuncionario"].Value.ToString();
            FormMain.msktxtbox_nfun_cpf.Text = dataGridView1.CurrentRow.Cells["CPF"].Value.ToString();
            FormMain.txtbox_nfunc_nomecompleto.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            FormMain.txtbox_nfunc_email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            FormMain.combobox_nfunc_equipe.Text = dataGridView1.CurrentRow.Cells["Equipe"].Value.ToString();
            FormMain.ShowDialog();
        }
    }
}
