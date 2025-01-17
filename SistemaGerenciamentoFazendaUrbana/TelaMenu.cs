using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGerenciamentoFazendaUrbana
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void btn_menu_producao_Click(object sender, EventArgs e)
        {
            TelaProducao FormMain = new TelaProducao();
            FormMain.Show();
        }

        private void btn_menu_insumos_Click(object sender, EventArgs e)
        {
            TelaInsumos FormMain = new TelaInsumos();
            FormMain.Show();
        }

        private void btn_menu_fornecedores_Click(object sender, EventArgs e)
        {
            TelaFornecedores FormMain = new TelaFornecedores();
            FormMain.Show();
        }

        private void btn_menu_clientes_Click(object sender, EventArgs e)
        {
            TelaClientes FormMain = new TelaClientes();
            FormMain.Show();
        }

        private void btn_menu_funcionarios_Click(object sender, EventArgs e)
        {
            TelaFuncionarios FormMain = new TelaFuncionarios();
            FormMain.Show();
        }

        private void btn_menu_equipes_Click(object sender, EventArgs e)
        {
            TelaEquipes FormMain = new TelaEquipes();
            FormMain.Show();
        }

        private void btn_menu_compras_Click(object sender, EventArgs e)
        {
            TelaCompras FormMain = new TelaCompras();
            FormMain.Show();
        }

        private void btn_menu_vendas_Click(object sender, EventArgs e)
        {
            TelaVendas FormMain = new TelaVendas();
            FormMain.Show();
        }

        private void btn_menu_usuario_Click(object sender, EventArgs e)
        {
            TelaUsuario FormMain = new TelaUsuario();
            FormMain.Show();
        }

        private void TelaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dlg == DialogResult.No)
            { 
                e.Cancel = true;
            }
        }
    }
}
