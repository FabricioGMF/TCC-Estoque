using BLL;
using System;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class ProdutosEmFaltaForm : Form
    {
        //Inicialização do formulário de produtos em falta:
        public ProdutosEmFaltaForm()
        {
            InitializeComponent();
        }

        //Carregamento do formulário de produtos em falta:
        private void ProdutosEmFaltaForm_Load(object sender, EventArgs e)
        {
            ProdutosBLL produto = new ProdutosBLL();
            dgvProdutosEmFalta.DataSource = produto.ProdutosEmFalta();
        }
    }
}
