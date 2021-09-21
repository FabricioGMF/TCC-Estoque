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

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm obj = new ClientesForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosForm obj = new ProdutosForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendasForm obj = new VendasForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ProdutosEmFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosEmFaltaForm obj = new ProdutosEmFaltaForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }
    }
}
