using BLL;
using Estoque;
using System;
using System.Windows.Forms;
using UIWindows.Outros;

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
            ItemVendaBLL objItem = new ItemVendaBLL();
            dgvItem.DataSource = objItem.ListaItens;
            
            //dgvProdutoVenda.DataSource = obj.ListaDeProdutos;
            cbxCliente.DataSource = obj.ListaDeClientes;
            cbxCliente.DisplayMember = "Nome";
            cbxCliente.ValueMember = "Codigo";
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                VendaInformation venda = new VendaInformation();
                venda.Quantidade = int.Parse(txtQuantidade.Text);

                venda.CodigoCliente = (int)cbxCliente.SelectedValue;
                
                venda.CodigoProduto = (int)dgvProdutoVenda[0, dgvProdutoVenda.CurrentRow.Index].Value;
                venda.DataVenda = DateTime.Now;
                venda.PrecoUnitario = Convert.ToDecimal(txtPrecoUnitario.Text);

                txtTotalProduto.Text = (venda.PrecoUnitario * venda.Quantidade).ToString();
                venda.Faturado = decimal.Parse(txtTotalProduto.Text);

                VendasBLL obj = new VendasBLL();
                obj.Incluir(venda);
                MessageBox.Show("A venda foi realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvProdutoVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescricaoProduto.Text = dgvProdutoVenda[1, dgvProdutoVenda.CurrentRow.Index].Value.ToString();
            txtPrecoUnitario.Text = dgvProdutoVenda[2, dgvProdutoVenda.CurrentRow.Index].Value.ToString();
        }

        private void lblTotalProduto_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscarProduto_Click(object sender, EventArgs e)
        {
            PesquisaProdutoForm obj = new PesquisaProdutoForm
            {
                MdiParent = this
            };
            obj.Show();
        }

        private void CbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
