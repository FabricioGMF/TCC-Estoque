using BLL;
using Loja;
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
            cbxProduto.DataSource = obj.ListaDeProdutos;
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
                venda.CodigoProduto = (int)cbxProduto.SelectedValue;
                venda.DataVenda = DateTime.Now;
                venda.Faturado = false;

                VendasBLL obj = new VendasBLL();
                obj.Incluir(venda);
                MessageBox.Show("A venda foi realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
