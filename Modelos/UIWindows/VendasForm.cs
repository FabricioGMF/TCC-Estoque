using BLL;
using Estoque;
using System;
using System.Data;
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
            dgvProdutoVenda.DataSource = obj.ListaDeProdutos;
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

                txtFaturado.Text = (venda.PrecoUnitario * venda.Quantidade).ToString();
                venda.Faturado = decimal.Parse(txtFaturado.Text);

                VendasBLL obj = new VendasBLL();
                obj.Incluir(venda);
                MessageBox.Show("A venda foi realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvProdutoVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeProdVenda.Text = dgvProdutoVenda[1, dgvProdutoVenda.CurrentRow.Index].Value.ToString();
            txtPrecoUnitario.Text = dgvProdutoVenda[2, dgvProdutoVenda.CurrentRow.Index].Value.ToString();
        }
    }
}
