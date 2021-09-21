using BLL;
using Estoque.Modelos;
using System;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtNome.Focus();
        }

        public void AtualizaGrid()
        {
            ClientesBLL obj = new ClientesBLL();
            dgvClientes.DataSource = obj.Listagem(txtFiltro.Text);

            try
            {
                if(dgvClientes.CurrentRow != null)
                {
                    txtCodigo.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtEmail.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtTelefone.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtCidade.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtUF.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
                }

                if (dgvClientes.RowCount > 0)
                {
                    txtCodigo.Text = "";
                    txtNome.Text = "";
                    txtEmail.Text = "";
                    txtTelefone.Text = "";
                    txtCidade.Text = "";
                    txtUF.Text = "";
                }
            }
            catch
            {
                txtCodigo.Text = "";
                txtNome.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";
                txtCidade.Text = "";
                txtUF.Text = "";
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteInformation cliente = new ClienteInformation();
                cliente.Nome = txtNome.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.UF = txtUF.Text;

                ClientesBLL obj = new ClientesBLL();
                obj.Incluir(cliente);
                MessageBox.Show("O cliente foi incluido com sucesso!");
                txtCodigo.Text = Convert.ToString(cliente.Codigo);
                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para alteração.");
            }
            else
                try
                {
                    ClienteInformation cliente = new ClienteInformation();
                    cliente.Codigo = int.Parse(txtCodigo.Text);
                    cliente.Nome = txtNome.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Telefone = txtTelefone.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.UF = txtUF.Text;

                    ClientesBLL obj = new ClientesBLL();
                    obj.Alterar(cliente);
                    MessageBox.Show("O cliente foi alterado com sucesso!");
                    AtualizaGrid();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado antes da exclusão.");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);

                    ClientesBLL obj = new ClientesBLL();
                    obj.Excluir(codigo);
                    MessageBox.Show("O cliente foi excluido com sucesso!");
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

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Atualizando os objetos TextBox
            txtCodigo.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
            txtTelefone.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
            txtUF.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
        }
    }
}
