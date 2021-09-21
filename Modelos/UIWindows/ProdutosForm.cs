using BLL;
using Loja;
using System;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class ProdutosForm : Form
    {
        public ProdutosForm()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        { //Comunicação com a camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            dgvProdutos.DataSource = obj.Listagem(txtFiltro.Text);

            txtCodigo.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtPreco.Text = dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtEstoque.Text = dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value.ToString();
        }

        private void ProdutosForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtNome.Focus();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            txtEstoque.Text = "";
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoInformation produto = new ProdutoInformation();
                produto.Nome = txtNome.Text;
                produto.Preco = Convert.ToDecimal(txtPreco.Text);
                produto.Estoque = Convert.ToInt32(txtEstoque.Text);

                ProdutosBLL obj = new ProdutosBLL();
                obj.Incluir(produto);
                MessageBox.Show("O produto foi incluido com sucesso!");
                txtCodigo.Text = Convert.ToString(produto.Codigo);
                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            AtualizaGrid();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para alteração.");
            }
            else
                try
                {
                    ProdutoInformation produto = new ProdutoInformation();
                    produto.Codigo = int.Parse(txtCodigo.Text);
                    produto.Nome = txtNome.Text;
                    produto.Preco = Convert.ToDecimal(txtPreco.Text);
                    produto.Estoque = Convert.ToInt32(txtEstoque.Text);

                    ProdutosBLL obj = new ProdutosBLL();
                    obj.Alterar(produto);
                    MessageBox.Show("O produto foi alterado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                AtualizaGrid();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um produto deve ser selecionado antes da exclusão.");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);

                    ProdutosBLL obj = new ProdutosBLL();
                    obj.Excluir(codigo);
                    MessageBox.Show("O produto foi excluido com sucesso!");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtPreco.Text = dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtEstoque.Text = dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value.ToString();
        }
    }
}
