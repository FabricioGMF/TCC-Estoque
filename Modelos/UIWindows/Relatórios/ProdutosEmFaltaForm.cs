using BLL;
using System;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class ProdutosEmFaltaForm : Form
    {
        public ProdutosEmFaltaForm()
        {
            InitializeComponent();
        }

        private void ProdutosEmFaltaForm_Load(object sender, EventArgs e)
        {
            ProdutosBLL produto = new ProdutosBLL();
            dgvProdutosEmFalta.DataSource = produto.ProdutosEmFalta();
        }
    }
}
