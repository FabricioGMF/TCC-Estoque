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
                    mskRG.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtLogradouro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtBairro.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtCidade.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
                    cmbUF.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
                    mskCEP.Text = dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString();
                    txtEmail.Text = dgvClientes[9, dgvClientes.CurrentRow.Index].Value.ToString();
                    mskTelefone.Text = dgvClientes[10, dgvClientes.CurrentRow.Index].Value.ToString();
                    mskTelefone2.Text = dgvClientes[11, dgvClientes.CurrentRow.Index].Value.ToString();
                    dtpDataCadastro.Text = dgvClientes[12, dgvClientes.CurrentRow.Index].Value.ToString();
                }

                if (dgvClientes.RowCount > 0)
                {
                    txtCodigo.Text = "";
                    txtNome.Text = "";
                    mskCPF_CNPJ.Text = "";
                    mskRG.Text = "";
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
                mskRG.Text = "";
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
            mskRG.Text = "";
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
                cliente.RG = mskRG.Text;
                cliente.Logradouro = txtLogradouro.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.UF = cmbUF.Text;
                cliente.CEP = mskCEP.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefone = mskTelefone.Text;
                cliente.Telefone2 = mskTelefone2.Text;
                cliente.DataCadastro = dtpDataCadastro.Value;

                Valida_Campos_Cliente(); //Validação de Campos

                ClientesBLL obj = new ClientesBLL();

                if(txtNome.Text.Length != 0 && mskCPF_CNPJ.Text.Length != 0 && mskRG.Text.Length != 0 &&
                    txtLogradouro.Text.Length != 0 && txtBairro.Text.Length != 0 && txtCidade.Text.Length != 0 ||
                    cmbUF.Text.Length != 0 && mskCEP.Text.Length != 0 && txtEmail.Text.Length != 0 &&
                    mskTelefone.Text.Length != 0)
                {
                    obj.Incluir(cliente);
                    MessageBox.Show("O cliente foi incluido com sucesso!");
                    txtCodigo.Text = Convert.ToString(cliente.Codigo);
                    AtualizaGrid();
                }
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
                    cliente.RG = mskRG.Text;
                    cliente.Logradouro = txtLogradouro.Text;
                    cliente.Bairro = txtBairro.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.UF = cmbUF.Text;
                    cliente.CEP = mskCEP.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Telefone = mskTelefone.Text;
                    cliente.Telefone2 = mskTelefone2.Text;
                    cliente.DataCadastro = dtpDataCadastro.Value;

                    Valida_Campos_Cliente(); //Validação de Campos

                    ClientesBLL obj = new ClientesBLL();

                    if (txtNome.Text.Length != 0 && mskCPF_CNPJ.Text.Length != 0 && mskRG.Text.Length != 0 &&
                        txtLogradouro.Text.Length != 0 && txtBairro.Text.Length != 0 && txtCidade.Text.Length != 0 ||
                        cmbUF.Text.Length != 0 && mskCEP.Text.Length != 0 && txtEmail.Text.Length != 0 &&
                        mskTelefone.Text.Length != 0)
                    {
                        obj.Alterar(cliente);
                        MessageBox.Show("O cliente foi alterado com sucesso!");
                        AtualizaGrid();
                    }
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
                    if (MessageBox.Show("Tem certeza que deseja excluir o cliente selecionado?", "Confirmação de exclusão",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int codigo = Convert.ToInt32(txtCodigo.Text);

                        ClientesBLL obj = new ClientesBLL();
                        obj.Excluir(codigo);
                        MessageBox.Show("O cliente foi excluido com sucesso!");
                        AtualizaGrid();
                    }
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
            mskRG.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
            txtLogradouro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
            txtBairro.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
            cmbUF.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
            mskCEP.Text = dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvClientes[9, dgvClientes.CurrentRow.Index].Value.ToString();
            mskTelefone.Text = dgvClientes[10, dgvClientes.CurrentRow.Index].Value.ToString();
            mskTelefone2.Text = dgvClientes[11, dgvClientes.CurrentRow.Index].Value.ToString();
            dtpDataCadastro.Text = dgvClientes[12, dgvClientes.CurrentRow.Index].Value.ToString();
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

        //Validação de campos:
        public void Valida_Campos_Cliente()
        {
            //- Nome/Razão Social:
            if (txtNome.Text.Trim().Length == 0)
            {
                errNomeRazao.SetError(txtNome, "Digite o nome ou razão social do cliente");
            }
            else
            {
                errNomeRazao.Clear();
            }

            //- CPF/CNPJ:
            if (mskCPF_CNPJ.Text.Trim().Length == 0)
            {
                errCPF_CNPJ.SetError(mskCPF_CNPJ, "Digite um CPF ou CNPJ válido");
            }
            else
            {
                errCPF_CNPJ.Clear();
            }

            //- CPF/CNPJ (Seleção de opção):
            if (cmbCPF_CNPJ.Text == "")
            {
                errOpCPF_CNPJ.SetError(cmbCPF_CNPJ, "Selecione uma opção");
            }
            else
            {
                errOpCPF_CNPJ.Clear();
            }

            //- RG:
            if (mskRG.Text == "")
            {
                errRG.SetError(mskRG, "Digite um RG válido");
            }
            else
            {
                errRG.Clear();
            }

            //- Logradouro:
            if (txtLogradouro.Text == "")
            {
                errLogradouro.SetError(txtLogradouro, "Digite um logradouro");
            }
            else
            {
                errLogradouro.Clear();
            }

            //- Bairro:
            if (txtBairro.Text == "")
            {
                errBairro.SetError(txtBairro, "Digite um bairro");
            }
            else
            {
                errBairro.Clear();
            }

            //- Cidade:
            if (txtCidade.Text == "")
            {
                errCidade.SetError(txtCidade, "Digite uma cidade");
            }
            else
            {
                errCidade.Clear();
            }

            //- UF:
            if (cmbUF.Text == "")
            {
                errUF.SetError(cmbUF, "Selecione um estado");
            }
            else
            {
                errUF.Clear();
            }

            //- CEP:
            if (mskCEP.Text == "")
            {
                errCEP.SetError(mskCEP, "Digite um CEP válido");
            }
            else
            {
                errCEP.Clear();
            }

            //- E-mail:
            if(txtEmail.Text == "")
            {
                errEmail.SetError(txtEmail, "Digite um e-mail válido");
            }
            else
            {
                errEmail.Clear();
            }

            //- Telefone:
            if (mskTelefone.Text == "")
            {
                errTelefone1.SetError(mskTelefone, "Digite um telefone válido");
            }
            else
            {
                errTelefone1.Clear();
            }
        }
    }
}
