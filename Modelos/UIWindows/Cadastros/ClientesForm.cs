using BLL;
using Estoque.Modelos;
using System;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class ClientesForm : Form
    {
        //Inicialização do formulário de clientes:
        public ClientesForm()
        {
            InitializeComponent();
        }

        //Carrega o formulário de clientes:
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtNome.Focus();
        }

        //Atualiza tabela de clientes:
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
                    mskCPF_CNPJ.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtLogradouro.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtBairro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtCidade.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
                    cmbUF.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
                    mskCEP.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtEmail.Text = dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString();
                    mskTelefone.Text = dgvClientes[9, dgvClientes.CurrentRow.Index].Value.ToString();
                    mskTelefone2.Text = dgvClientes[10, dgvClientes.CurrentRow.Index].Value.ToString();
                    dtpDataCadastro.Text = dgvClientes[11, dgvClientes.CurrentRow.Index].Value.ToString();
                }

                if (dgvClientes.RowCount > 0)
                {
                    txtCodigo.Text = "";
                    txtNome.Text = "";
                    mskCPF_CNPJ.Text = "";
                    txtLogradouro.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    cmbUF.Text = "";
                    mskCEP.Text = "";
                    txtEmail.Text = "";
                    mskTelefone.Text = "";
                    mskTelefone2.Text = "";
                }
            }
            catch
            {
                txtCodigo.Text = "";
                txtNome.Text = "";
                mskCPF_CNPJ.Text = "";
                txtLogradouro.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                cmbUF.Text = "";
                mskCEP.Text = "";
                txtEmail.Text = "";
                mskTelefone.Text = "";
                mskTelefone2.Text = "";
            }
        }

        //Limpa campos do formulário de clientes:
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            mskCPF_CNPJ.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cmbUF.Text = "";
            mskCEP.Text = "";
            txtEmail.Text = "";
            mskTelefone.Text = "";
            mskTelefone2.Text = "";
        }

        //Inclusão de cliente:
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteInformation cliente = new ClienteInformation();
                cliente.Nome = txtNome.Text;
                cliente.CPFCNPJ = mskCPF_CNPJ.Text;
                cliente.Logradouro = txtLogradouro.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.UF = cmbUF.Text;
                cliente.CEP = mskCEP.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefone = mskTelefone.Text;
                cliente.Telefone2 = mskTelefone2.Text;
                cliente.DataCadastro = dtpDataCadastro.Value;
                
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

        //Alteração de cliente:
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para alteração.");
            }
            else
            {
                try
                {
                    ClienteInformation cliente = new ClienteInformation();
                    cliente.Codigo = int.Parse(txtCodigo.Text);
                    cliente.Nome = txtNome.Text;
                    cliente.CPFCNPJ = mskCPF_CNPJ.Text;
                    cliente.Logradouro = txtLogradouro.Text;
                    cliente.Bairro = txtBairro.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.UF = cmbUF.Text;
                    cliente.CEP = mskCEP.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Telefone = mskTelefone.Text;
                    cliente.Telefone2 = mskTelefone2.Text;
                    cliente.DataCadastro = dtpDataCadastro.Value;

                    ClientesBLL obj = new ClientesBLL();
                    obj.Alterar(cliente);
                    MessageBox.Show("O cliente foi alterado com sucesso!");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        //Exclusão de cliente:
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado antes da exclusão.");
            }
            else
            {
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
        }

        //Atualiza tabela de clientes de acordo com o filtro:
        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        //Seleção de registro da lista de clientes:
        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Atualizando os objetos TextBox
            txtCodigo.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
            mskCPF_CNPJ.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
            txtLogradouro.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
            txtBairro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
            cmbUF.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
            mskCEP.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString();
            mskTelefone.Text = dgvClientes[9, dgvClientes.CurrentRow.Index].Value.ToString();
            mskTelefone2.Text = dgvClientes[10, dgvClientes.CurrentRow.Index].Value.ToString();
            dtpDataCadastro.Text = dgvClientes[11, dgvClientes.CurrentRow.Index].Value.ToString();
        }

        //Definir máscara do campo de CPF/CNPJ, conforme a opção selecionada:
        private void MskCPF_CNPJ_TextChanged(object sender, EventArgs e)
        {
            if (cmbCPF_CNPJ.SelectedItem == "CNPJ")
            {
                mskCPF_CNPJ.Mask = "00.000.000/0000-00";
            }
            else if (cmbCPF_CNPJ.SelectedItem == "CPF")
            {
                mskCPF_CNPJ.Mask = "000.000.000-00";
            }
        }

        //Aceitar somente números no campo de CPF/CNPJ:
        private void MskCPF_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Aceitar somente números no campo de CEP:
        private void MskCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Aceitar somente números no campo de Telefone (1):
        private void MskTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Aceitar somente números no campo de Telefone (2):
        private void MskTelefone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
