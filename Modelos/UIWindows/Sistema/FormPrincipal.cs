using System;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class FormPrincipal : Form
    {
        //Inicialização do formulário:
        public FormPrincipal()
        {
            InitializeComponent();
        }

        //Carregamento do formulário:
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        //Chamada do formulário de backup (em breve), ao clicar no botão correspondente:
        private void TsmiSisBackup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em breve", "Backup e Restauração", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Encerra a aplicação, ao clicar o botão de sair:
        private void TsmiSisSair_Click(object sender, EventArgs e)
        {
            //Pergunta se deseja encerrar a aplicação, caso a opção "sim" seja selecionada:
            if (MessageBox.Show("Deseja realmente sair?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Saindo...");
                Application.Exit();
            }
        }

        //Chamada do formulário de clientes:
        private void TsmiCadClientes_Click(object sender, EventArgs e)
        {
            ClientesForm obj = new ClientesForm
            {
                MdiParent = this
            };
            obj.Show();
        }

        //Chamada do formulário de produtos:
        private void TsmiCadProdutos_Click(object sender, EventArgs e)
        {
            ProdutosForm obj = new ProdutosForm
            {
                MdiParent = this
            };
            obj.Show();
        }

        //Chamada do formulário de vendas:
        private void TsmiMovVendas_Click(object sender, EventArgs e)
        {
            VendasForm obj = new VendasForm
            {
                MdiParent = this
            };
            obj.Show();
        }

        //Chamada do formulário do relatório de clientes (em breve):
        private void TsmiRelClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em breve", "Relatório de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Chamada do formulário do relatório de produtos (em breve):
        private void TsmiRelProdutos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em breve", "Relatório de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Chamada do formulário do relatório de vendas (em breve):
        private void TsmiRelVendas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em breve", "Relatório de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Chamada do formulário do relatório de produtos em falta:
        private void TsmiRelProdEmFalta_Click(object sender, EventArgs e)
        {
            ProdutosEmFaltaForm obj = new ProdutosEmFaltaForm
            {
                MdiParent = this
            };
            obj.Show();
        }

        //Chamada do formulário* de ajuda:
        private void TsmiAjuExibirAjuda_Click(object sender, EventArgs e)
        {

        }

        //Chamada da caixa de diálogo sobre, onde apresenta as informações básicas do sistema:
        private void TsmiAjuSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Controle de estoque" + "\n\nVersão 2021.0" + "\n\nDesenvolvido por: Fabrício Guimarães Marques de Faria", 
                "Sobre o sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
