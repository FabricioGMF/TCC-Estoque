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

            dgvProdutosEmFalta.Columns[0].HeaderText = "ID";
            dgvProdutosEmFalta.Columns[1].HeaderText = "Descrição";
            dgvProdutosEmFalta.Columns[2].HeaderText = "Valor de Compra";
            dgvProdutosEmFalta.Columns[3].HeaderText = "Valor de Venda";
            dgvProdutosEmFalta.Columns[4].HeaderText = "Estoque";
            dgvProdutosEmFalta.Columns[5].HeaderText = "Estoque Mínimo";
            dgvProdutosEmFalta.Columns[6].HeaderText = "Estoque Máximo";
            dgvProdutosEmFalta.Columns[7].HeaderText = "Estoque de Segurança";
        }
    }
}
