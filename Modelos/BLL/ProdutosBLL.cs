using Estoque;
using System;
using System.Collections;
using System.Data;

namespace BLL
{
    public class ProdutosBLL
    {
        //Chamada da lista de produtos em falta:
        public ArrayList ProdutosEmFalta()
        {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.ProdutosEmFalta();
        }

        //Regras de negócio na operação de inclusão de produto:
        public void Incluir(ProdutoInformation produto)
        {
            if (produto.Descricao.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if(produto.ValorVenda < 0)
            {
                throw new Exception("O valor de venda do produto não pode ser negativo");
            }

            if (produto.ValorCompra < 0)
            {
                throw new Exception("O valor de compra do produto não pode ser negativo");
            }

            if (produto.ValorVenda < produto.ValorCompra)
            {
                throw new Exception("O valor de venda não pode ser menor que o valor de compra");
            }

            if (produto.Estoque < 0)
            {
                throw new Exception("O estoque do produto não pode ser negativo");
            }

            if (produto.EstoqueMinimo < 0)
            {
                throw new Exception("O estoque mínimo do produto não pode ser negativo");
            }

            if (produto.EstoqueMaximo < 10)
            {
                throw new Exception("O estoque máximo do produto não pode ser menor que 10");
            }

            if (produto.EstoqueSeguranca < 0)
            {
                throw new Exception("O estoque de segurança do produto não pode ser negativo");
            }

            if (produto.EstoqueMinimo >= produto.EstoqueMaximo)
            {
                throw new Exception("O estoque mínimo não pode ser maior ou igual ao estoque máximo");
            }

            if (produto.EstoqueMaximo <= produto.EstoqueMinimo)
            {
                throw new Exception("O estoque máximo não pode ser menor ou igual ao estoque mínimo");
            }

            if (produto.EstoqueMinimo == 0 || produto.EstoqueMaximo == 0)
            {
                throw new Exception("O estoque mínimo e/ou estoque máximo não podem ser iguais a 0");
            }

            if (produto.Estoque > produto.EstoqueMaximo)
            {
                throw new Exception("O estoque não pode estar acima do estoque máximo");
            }

            if (produto.Estoque < produto.EstoqueMinimo)
            {
                throw new Exception("O estoque não pode estar abaixo do estoque mínimo");
            }

            ProdutosDAL obj = new ProdutosDAL();
            obj.Incluir(produto);
        }

        //Regras de negócio na operação de alteração de produto:
        public void Alterar(ProdutoInformation produto)
        {
            if (produto.Descricao.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (produto.ValorVenda < 0)
            {
                throw new Exception("O valor de venda do produto não pode ser negativo");
            }

            if (produto.ValorCompra < 0)
            {
                throw new Exception("O valor de compra do produto não pode ser negativo");
            }

            if (produto.ValorVenda < produto.ValorCompra)
            {
                throw new Exception("O valor de venda não pode ser menor que o valor de compra");
            }

            if (produto.Estoque < 0)
            {
                throw new Exception("O estoque do produto não pode ser negativo");
            }

            if (produto.EstoqueMinimo < 0)
            {
                throw new Exception("O estoque mínimo do produto não pode ser negativo");
            }

            if (produto.EstoqueMaximo < 10)
            {
                throw new Exception("O estoque máximo do produto não pode ser menor que 10");
            }

            if (produto.EstoqueSeguranca < 0)
            {
                throw new Exception("O estoque de segurança do produto não pode ser negativo");
            }

            if (produto.EstoqueMinimo >= produto.EstoqueMaximo)
            {
                throw new Exception("O estoque mínimo não pode ser maior ou igual ao estoque máximo");
            }

            if (produto.EstoqueMaximo <= produto.EstoqueMinimo)
            {
                throw new Exception("O estoque máximo não pode ser menor ou igual ao estoque mínimo");
            }

            if (produto.EstoqueMinimo == 0 || produto.EstoqueMaximo == 0)
            {
                throw new Exception("O estoque mínimo e/ou estoque máximo não podem ser iguais a 0");
            }

            if (produto.Estoque > produto.EstoqueMaximo)
            {
                throw new Exception("O estoque não pode estar acima do estoque máximo");
            }

            if (produto.Estoque < produto.EstoqueMinimo)
            {
                throw new Exception("O estoque não pode estar abaixo do estoque mínimo");
            }

            ProdutosDAL obj = new ProdutosDAL();
            obj.Alterar(produto);
        }

        //Operação de exclusão de produto:
        public void Excluir(int codigo)
        {
            ProdutosDAL obj = new ProdutosDAL();
            obj.Excluir(codigo);
        }

        //Chamada da tabela de resultados, de acordo com o filtro:
        public DataTable Listagem(string filtro)
        {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.Listagem(filtro);
        }

        //Chamada da operação do uso do estoque de segurança:
        public int Uso_EstoqueSeguranca(ProdutoInformation produto)
        {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.Uso_EstoqueSeguranca(produto);
        }
    }
}
