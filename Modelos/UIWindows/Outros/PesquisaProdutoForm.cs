using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows.Outros
{
    public partial class PesquisaProdutoForm : Form
    {
        public PesquisaProdutoForm()
        {
            InitializeComponent();
        }

        private void PesquisaProdutoForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtPesquisarProduto.Focus();
        }

        public void AtualizaGrid()
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

        private void TxtPesquisaProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnFiltroProduto_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
    }
}
