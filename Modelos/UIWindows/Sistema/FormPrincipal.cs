using System;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void TsmiSisBackup_Click(object sender, EventArgs e)
        {

        }

        private void TsmiSisSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Saindo...");
                Application.Exit();
            }
        }

        private void TsmiCadClientes_Click(object sender, EventArgs e)
        {
            ClientesForm obj = new ClientesForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void TsmiCadProdutos_Click(object sender, EventArgs e)
        {
            ProdutosForm obj = new ProdutosForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void TsmiMovVendas_Click(object sender, EventArgs e)
        {
            VendasForm obj = new VendasForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void TsmiRelClientes_Click(object sender, EventArgs e)
        {

        }

        private void TsmiRelProdutos_Click(object sender, EventArgs e)
        {

        }

        private void TsmiRelVendas_Click(object sender, EventArgs e)
        {

        }

        private void TsmiRelProdEmFalta_Click(object sender, EventArgs e)
        {
            ProdutosEmFaltaForm obj = new ProdutosEmFaltaForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void TsmiAjuExibirAjuda_Click(object sender, EventArgs e)
        {

        }

        private void TsmiAjuSobre_Click(object sender, EventArgs e)
        {

        }
    }
}
