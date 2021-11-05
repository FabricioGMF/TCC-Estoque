using BLL;
using Estoque;
using System;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class ProdutosForm : Form
    {
        //Inicialização do formulário de produtos:
        public ProdutosForm()
        {
            InitializeComponent();
        }

        //Carrega o formulário de produtos:
        private void ProdutosForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtDescricao.Focus();
        }

        //Atualiza tabela de produtos
        public void AtualizaGrid()
        { //Comunicação com a camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            dgvProdutos.DataSource = obj.Listagem(txtFiltro.Text);

            try
            {
                if (dgvProdutos.CurrentRow != null)
                {
                    txtCodigo.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
                    txtDescricao.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
                    numValorCompra.Value = (decimal)dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value;
                    numValorVenda.Value = (decimal)dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value;
                    numEstoque.Value = (int)dgvProdutos[4, dgvProdutos.CurrentRow.Index].Value;
                    numEstoqueMinimo.Value = (int)dgvProdutos[5, dgvProdutos.CurrentRow.Index].Value;
                    numEstoqueMaximo.Value = (int)dgvProdutos[6, dgvProdutos.CurrentRow.Index].Value;
                    txtEstoqueSeguranca.Text = dgvProdutos[7, dgvProdutos.CurrentRow.Index].Value.ToString();
                }

                if (dgvProdutos.RowCount > 0)
                {
                    txtCodigo.Text = "";
                    txtDescricao.Text = "";
                    numValorCompra.Value = 0;
                    numValorVenda.Value = 0;
                    numEstoque.Value = 0;
                    numEstoqueMinimo.Value = 0;
                    numEstoqueMaximo.Value = 0;
                    txtEstoqueSeguranca.Text = "";
                }
            }
            catch
            {
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                numValorCompra.Value = 0;
                numValorVenda.Value = 0;
                numEstoque.Value = 0;
                numEstoqueMinimo.Value = 0;
                numEstoqueMaximo.Value = 0;
                txtEstoqueSeguranca.Text = "";
            }
        }       

        //Limpa campos do formulário de produtos:
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            numValorCompra.Value = 0;
            numValorVenda.Value = 0;
            numEstoque.Value = 0;
            numEstoqueMinimo.Value = 0;
            numEstoqueMaximo.Value = 0;
            txtEstoqueSeguranca.Text = "";
        }

        //Inclusão de produto:
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoInformation produto = new ProdutoInformation();
                produto.Descricao = txtDescricao.Text;
                produto.ValorCompra = Convert.ToDecimal(numValorCompra.Value);
                produto.ValorVenda = Convert.ToDecimal(numValorVenda.Value);
                produto.Estoque = Convert.ToInt32(numEstoque.Value);
                produto.EstoqueMinimo = Convert.ToInt32(numEstoqueMinimo.Value);
                produto.EstoqueMaximo = Convert.ToInt32(numEstoqueMaximo.Value);

                if (produto.EstoqueMaximo >= 10)
                {
                    txtEstoqueSeguranca.Text = (produto.EstoqueMaximo * 0.1).ToString();
                    produto.EstoqueSeguranca = Convert.ToInt32(txtEstoqueSeguranca.Text);
                }

                Valida_Campos_Produto();

                ProdutosBLL obj = new ProdutosBLL();

                if (txtDescricao.Text.Length != 0 && numValorCompra.Value != 0 &&
                numEstoque.Value != 0 && numValorVenda.Value != 0 &&
                numEstoqueMinimo.Value != 0 && numEstoqueMaximo.Value != 0)
                {
                    obj.Incluir(produto);
                    MessageBox.Show("O produto foi incluido com sucesso!");
                    txtCodigo.Text = Convert.ToString(produto.Codigo);
                    AtualizaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            AtualizaGrid();
        }

        //Alteração de produto:
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um produto deve ser selecionado para alteração.");
            }
            else
            {
                try
                {
                    ProdutoInformation produto = new ProdutoInformation();
                    produto.Codigo = Convert.ToInt32(txtCodigo.Text);
                    produto.Descricao = txtDescricao.Text;
                    produto.ValorCompra = Convert.ToDecimal(numValorCompra.Value);
                    produto.ValorVenda = Convert.ToDecimal(numValorVenda.Value);
                    produto.Estoque = Convert.ToInt32(numEstoque.Value);
                    produto.EstoqueMinimo = Convert.ToInt32(numEstoqueMinimo.Value);
                    produto.EstoqueMaximo = Convert.ToInt32(numEstoqueMaximo.Value);

                    if (produto.EstoqueMaximo >= 10)
                    {
                        txtEstoqueSeguranca.Text = (produto.EstoqueMaximo * 0.1).ToString();
                        produto.EstoqueSeguranca = Convert.ToInt32(txtEstoqueSeguranca.Text);
                    }

                    Valida_Campos_Produto();

                    ProdutosBLL obj = new ProdutosBLL();

                    if (txtDescricao.Text.Length != 0 && numValorCompra.Value != 0 &&
                    numEstoque.Value != 0 && numValorVenda.Value != 0 &&
                    numEstoqueMinimo.Value != 0 && numEstoqueMaximo.Value != 0)
                    {
                        obj.Alterar(produto);
                        MessageBox.Show("O produto foi alterado com sucesso!");
                        AtualizaGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                AtualizaGrid();
            }
        }

        //Exclusão de produto:
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um produto deve ser selecionado antes da exclusão.");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir o produto selecionado?", "Confirmação de exclusão", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int codigo = Convert.ToInt32(txtCodigo.Text);

                        ProdutosBLL obj = new ProdutosBLL();
                        obj.Excluir(codigo);
                        MessageBox.Show("O produto foi excluido com sucesso!");
                        AtualizaGrid();
                    }                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Atualiza tabela de produtos de acordo com o filtro:
        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        //Seleção de registro da lista de produtos:
        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtDescricao.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
            numValorCompra.Value = (decimal)dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value;
            numValorVenda.Value = (decimal)dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value;
            numEstoque.Value = (int)dgvProdutos[4, dgvProdutos.CurrentRow.Index].Value;
            numEstoqueMinimo.Value = (int)dgvProdutos[5, dgvProdutos.CurrentRow.Index].Value;
            numEstoqueMaximo.Value = (int)dgvProdutos[6, dgvProdutos.CurrentRow.Index].Value;
            txtEstoqueSeguranca.Text = dgvProdutos[7, dgvProdutos.CurrentRow.Index].Value.ToString();
        }

        //Validação de campos:
        public void Valida_Campos_Produto()
        {
            //- Descrição:
            if (txtDescricao.Text == "")
            {
                errDescricao.SetError(txtDescricao, "Digite a descrição");
            }
            else
            {
                errDescricao.Clear();
            }

            //- Valor Compra:
            if (numValorCompra.Value == 0)
            {
                errValorCompra.SetError(numValorCompra, "Insira o valor de compra");
            }
            else
            {
                errValorCompra.Clear();
            }

            //- Estoque:
            if (numEstoque.Value == 0)
            {
                errEstoque.SetError(numEstoque, "Insira o estoque");
            }
            else
            {
                errEstoque.Clear();
            }

            //- Valor Venda:
            if (numValorVenda.Value == 0)
            {
                errValorVenda.SetError(numValorVenda, "Insira o valor de venda");
            }
            else
            {
                errValorVenda.Clear();
            }

            //- Estoque Mínimo:
            if (numEstoqueMinimo.Value == 0)
            {
                errEstoqueMinimo.SetError(numEstoqueMinimo, "Insira o estoque mínimo");
            }
            else
            {
                errEstoqueMinimo.Clear();
            }

            //- Estoque Máximo:
            if (numEstoqueMaximo.Value == 0)
            {
                errEstoqueMaximo.SetError(numEstoqueMaximo, "Insira o estoque máximo");
            }
            else
            {
                errEstoqueMaximo.Clear();
            }
        }
    }
}
