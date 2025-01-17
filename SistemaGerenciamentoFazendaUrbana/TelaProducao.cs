using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace SistemaGerenciamentoFazendaUrbana
{
    public partial class TelaProducao : Form
    {
        public TelaProducao()
        {
            InitializeComponent();
        }

        private void btn_add_producao_Click(object sender, EventArgs e)
        {
            TelaNovaProducao FormMain = new TelaNovaProducao();
            FormMain.ShowDialog();
        }

        private void btn_producao_voltar_Click(object sender, EventArgs e)
        {
            TelaMenu FormMain = new TelaMenu();
            this.Hide();
        }


        private void TelaProducao_Load(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus"))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Producoes", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btn_consultar_producao_Click(object sender, EventArgs e)
        {

            TelaNovaProducao FormMain = new TelaNovaProducao();
            FormMain.lbl_novaproducao.Text = "Consulta Produção";
            FormMain.btn_np_salvar.Visible = false;
            FormMain.txtbox_np_codigoprod.Text = dataGridView1.CurrentRow.Cells["IDProducao"].Value.ToString();
            FormMain.txtbox_np_nomedoproduto.Enabled = false;
            FormMain.txtbox_np_nomedoproduto.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            FormMain.combobox_np_classe.Enabled = false;
            FormMain.combobox_np_classe.Text = dataGridView1.CurrentRow.Cells["Classe"].Value.ToString();
            FormMain.txtbox_np_tempomedio.Enabled = false;
            FormMain.txtbox_np_tempomedio.Text = dataGridView1.CurrentRow.Cells["TempoMedioMaturacao"].Value.ToString();
            FormMain.combobox_np_medidadetempo.Enabled = false;
            FormMain.combobox_np_medidadetempo.Text = dataGridView1.CurrentRow.Cells["MedidaTempo"].Value.ToString();
            FormMain.txtbox_np_umidade.Enabled = false;
            FormMain.txtbox_np_umidade.Text = dataGridView1.CurrentRow.Cells["Umidade"].Value.ToString();
            FormMain.txtbox_np_temperatura.Enabled = false;
            FormMain.txtbox_np_temperatura.Text = dataGridView1.CurrentRow.Cells["Temperatura"].Value.ToString();
            FormMain.txtbox_np_niveldeluz.Enabled = false;
            FormMain.txtbox_np_niveldeluz.Text = dataGridView1.CurrentRow.Cells["NivelLuz"].Value.ToString();
            FormMain.dateTimePicker1.Enabled = false;
            FormMain.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["DataProducao"].Value.ToString();
            FormMain.rb_np_status_ativo.Enabled = false;
            FormMain.rb_np_status_inativo.Enabled = false;
            if (FormMain.rb_np_status_ativo.Checked == true)
            {
                FormMain.rb_np_status_ativo.Text = dataGridView1.CurrentRow.Cells["StatusProducao"].Value.ToString();
            }
            else
            {
                FormMain.rb_np_status_inativo.Text = dataGridView1.CurrentRow.Cells["StatusProducao"].Value.ToString();
            }
            FormMain.ShowDialog();
        }

        private void TelaProducao_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
