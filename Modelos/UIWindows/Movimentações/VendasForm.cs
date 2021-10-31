using BLL;
using Estoque;
using Estoque.Modelos;
using System;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class VendasForm : Form
    {
        public VendasForm()
        {
            InitializeComponent();
        }

        private void VendasForm_Load(object sender, EventArgs e)
        {
            VendasBLL obj = new VendasBLL();
            
            //dgvProdutosBusca.DataSource = obj.ListaDeProdutos;
            cbxCliente.DataSource = obj.ListaDeClientes;
            cbxCliente.DisplayMember = "Nome";
            cbxCliente.ValueMember = "Codigo";

            AtualizaGrid_SelecionarProd();
        }

        #region Item
        public void AtualizaGrid_Item()
        {
            ItemVendaBLL obj = new ItemVendaBLL();
            dgvItem.DataSource = obj.ListaItens();

            try
            {
                if (dgvItem.CurrentRow != null)
                {
                    dgvProdutosBusca[0, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                    dgvProdutosBusca[1, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                    dgvProdutosBusca[2, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                    dgvProdutosBusca[3, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                    dgvProdutosBusca[4, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                }

                if (dgvItem.RowCount > 0)
                {
                    txtNumVenda.Text = "";

                    txtCodigo.Text = "";
                    txtDescricaoProduto.Text = "";
                    numQtdItem.Value = 0;
                    txtPrecoUnitario.Text = "";
                    txtTotalItem.Text = "";
                }
            }
            catch
            {
                txtNumVenda.Text = "";

                txtCodigo.Text = "";
                txtDescricaoProduto.Text = "";
                numQtdItem.Value = 0;
                txtPrecoUnitario.Text = "";
                txtTotalItem.Text = "";
            }
        }       

        private void BtnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                ItemVendaInformation itemVenda = new ItemVendaInformation();
                itemVenda.CodigoProduto = Convert.ToInt32(txtCodigo.Text);
                itemVenda.QtdItem = Convert.ToInt32(numQtdItem.Value);
                itemVenda.ValorItem = Convert.ToDecimal(txtPrecoUnitario.Text);

                txtTotalItem.Text = (itemVenda.ValorItem * itemVenda.QtdItem).ToString();
                itemVenda.TotalItem = Convert.ToDecimal(txtTotalItem.Text);

                VendaInformation venda = new VendaInformation();
                txtTotalVenda.Text = (venda.Faturado + itemVenda.TotalItem).ToString();

                ItemVendaBLL obj = new ItemVendaBLL();
                obj.Incluir(itemVenda);
                MessageBox.Show("O item foi incluído com sucesso!");
                txtCodigo.Text = Convert.ToString(itemVenda.CodigoVenda);
                AtualizaGrid_Item();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            AtualizaGrid_Item();
        }

        private void BtnAlterarItem_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um item deve ser selecionado para alteração.");
            }
            else
            {
                try
                {
                    ItemVendaInformation itemVenda = new ItemVendaInformation();
                    itemVenda.CodigoProduto = Convert.ToInt32(txtCodigo.Text);
                    itemVenda.QtdItem = Convert.ToInt32(numQtdItem.Value);
                    itemVenda.ValorItem = Convert.ToDecimal(txtPrecoUnitario.Text);

                    txtTotalItem.Text = (itemVenda.ValorItem * itemVenda.QtdItem).ToString();

                    ItemVendaBLL obj = new ItemVendaBLL();
                    obj.Alterar(itemVenda);
                    MessageBox.Show("O item foi alterado com sucesso!");
                    AtualizaGrid_Item();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                AtualizaGrid_Item();
            }
        }

        private void BtnExcluirItem_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um item deve ser selecionado antes da exclusão.");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir o item selecionado?", "Confirmação de exclusão",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int codigo = Convert.ToInt32(txtCodigo.Text);

                        ItemVendaBLL obj = new ItemVendaBLL();
                        obj.Excluir(codigo);
                        MessageBox.Show("O item foi excluido com sucesso!");
                        AtualizaGrid_Item();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizaGrid_Item();
        }
        #endregion

        private void BtnRealizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                VendaInformation venda = new VendaInformation();
                //venda.Quantidade = int.Parse(txtQuantidade.Text);

                venda.CodigoCliente = (int)cbxCliente.SelectedValue;

                //venda.CodigoProduto = (int)dgvProdutoVenda[0, dgvProdutoVenda.CurrentRow.Index].Value;
                venda.DataVenda = dtpDataVenda.Value;
                //venda.PrecoUnitario = Convert.ToDecimal(txtPrecoUnitario.Text);

                //txtTotalProduto.Text = (venda.PrecoUnitario * venda.Quantidade).ToString();
                venda.Faturado = decimal.Parse(txtTotalItem.Text);

                VendasBLL obj = new VendasBLL();
                obj.Incluir(venda);
                MessageBox.Show("A venda foi realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Selecionar_Produto
        public void AtualizaGrid_SelecionarProd()
        { //Comunicação com a camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            dgvProdutosBusca.DataSource = obj.Listagem(txtPesquisarProduto.Text);

            if (dgvProdutosBusca.CurrentRow != null)
            {
                dgvProdutosBusca[0, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                dgvProdutosBusca[1, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                dgvProdutosBusca[2, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                dgvProdutosBusca[3, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                dgvProdutosBusca[4, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                dgvProdutosBusca[5, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                dgvProdutosBusca[6, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
                dgvProdutosBusca[7, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
            }
        }

        private void DgvProdutosBusca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProdutosBusca[0, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
            txtDescricaoProduto.Text = dgvProdutosBusca[1, dgvProdutosBusca.CurrentRow.Index].Value.ToString();
            txtPrecoUnitario.Text = dgvProdutosBusca[3, dgvProdutosBusca.CurrentRow.Index].Value.ToString();

            grpSelecionarProduto.Visible = false;
        }

        private void TxtPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            AtualizaGrid_SelecionarProd();
        }

        private void BtnBuscarProduto_Click(object sender, EventArgs e)
        {
            grpSelecionarProduto.Visible = true;
            txtPesquisarProduto.Focus();
        }
        #endregion
    }
}
