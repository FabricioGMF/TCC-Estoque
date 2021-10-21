using BLL;
using Estoque;
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

            try
            {
                if (dgvProdutos.CurrentRow != null)
                {
                    txtCodigo.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
                    txtNome.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
                    txtPreco.Text = dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value.ToString();
                    txtEstoque.Text = dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value.ToString();
                    txtEstoqueMinimo.Text = dgvProdutos[4, dgvProdutos.CurrentRow.Index].Value.ToString();
                    txtEstoqueMaximo.Text = dgvProdutos[5, dgvProdutos.CurrentRow.Index].Value.ToString();
                    txtEstoqueSeguranca.Text = dgvProdutos[6, dgvProdutos.CurrentRow.Index].Value.ToString();
                    txtEstoqueTotal.Text = dgvProdutos[7, dgvProdutos.CurrentRow.Index].Value.ToString();
                }

                if (dgvProdutos.RowCount > 0)
                {
                    txtCodigo.Text = "";
                    txtNome.Text = "";
                    txtPreco.Text = "";
                    txtEstoque.Text = "";
                    txtEstoqueMinimo.Text = "";
                    txtEstoqueMaximo.Text = "";
                    txtEstoqueSeguranca.Text = "";
                    txtEstoqueTotal.Text = "";
                }
            }
            catch
            {
                txtCodigo.Text = "";
                txtNome.Text = "";
                txtPreco.Text = "";
                txtEstoque.Text = "";
                txtEstoqueMinimo.Text = "";
                txtEstoqueMaximo.Text = "";
                txtEstoqueSeguranca.Text = "";
                txtEstoqueTotal.Text = "";
            }
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
            txtEstoqueMinimo.Text = "";
            txtEstoqueMaximo.Text = "";
            txtEstoqueSeguranca.Text = "";
            txtEstoqueTotal.Text = "";
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoInformation produto = new ProdutoInformation();
                produto.Nome = txtNome.Text;
                produto.Preco = Convert.ToDecimal(txtPreco.Text);
                produto.Estoque = Convert.ToInt32(txtEstoque.Text);
                produto.EstoqueMinimo = Convert.ToInt32(txtEstoqueMinimo.Text);
                produto.EstoqueMaximo = Convert.ToInt32(txtEstoqueMaximo.Text);
                produto.EstoqueSeguranca = Convert.ToInt32(txtEstoqueSeguranca.Text);

                txtEstoqueTotal.Text = (produto.Estoque + produto.EstoqueSeguranca).ToString();
                produto.EstoqueTotal = Convert.ToInt32(txtEstoqueTotal.Text);

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
                    produto.EstoqueMinimo = Convert.ToInt32(txtEstoqueMinimo.Text);
                    produto.EstoqueMaximo = Convert.ToInt32(txtEstoqueMaximo.Text);
                    produto.EstoqueSeguranca = Convert.ToInt32(txtEstoqueSeguranca.Text);

                    txtEstoqueTotal.Text = (produto.Estoque + produto.EstoqueSeguranca).ToString();
                    produto.EstoqueTotal = Convert.ToInt32(txtEstoqueTotal.Text);

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
            txtEstoqueMinimo.Text = dgvProdutos[4, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtEstoqueMaximo.Text = dgvProdutos[5, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtEstoqueSeguranca.Text = dgvProdutos[6, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtEstoqueTotal.Text = dgvProdutos[7, dgvProdutos.CurrentRow.Index].Value.ToString();
        }
    }
}
