using Estoque;
using System;
using System.Collections;
using System.Data;

namespace BLL
{
    public class ProdutosBLL
    {
        public ArrayList ProdutosEmFalta()
        {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.ProdutosEmFalta();
        }

        public void Incluir(ProdutoInformation produto)
        {
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if(produto.Preco < 0)
            {
                throw new Exception("O preço do produto não pode ser negativo");
            }

            if (produto.Estoque < 0)
            {
                throw new Exception("O estoque do produto não pode ser negativo");
            }

            if (produto.EstoqueMinimo < 0)
            {
                throw new Exception("O estoque mínimo do produto não pode ser negativo");
            }

            if (produto.EstoqueMaximo < 0)
            {
                throw new Exception("O estoque máximo do produto não pode ser negativo");
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

            if (produto.EstoqueTotal > produto.EstoqueMaximo)
            {
                throw new Exception("O estoque total não pode estar acima do estoque máximo");
            }

            if (produto.EstoqueTotal < produto.EstoqueMinimo)
            {
                throw new Exception("O estoque total não pode estar abaixo do estoque mínimo");
            }

            ProdutosDAL obj = new ProdutosDAL();
            obj.Incluir(produto);
        }

        public void Alterar(ProdutoInformation produto)
        {
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (produto.Preco < 0)
            {
                throw new Exception("O preço do produto não pode ser negativo");
            }

            if (produto.Estoque < 0)
            {
                throw new Exception("O estoque do produto não pode ser negativo");
            }

            if (produto.EstoqueMinimo < 0)
            {
                throw new Exception("O estoque mínimo do produto não pode ser negativo");
            }

            if (produto.EstoqueMaximo < 0)
            {
                throw new Exception("O estoque máximo do produto não pode ser negativo");
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

            if (produto.EstoqueTotal > produto.EstoqueMaximo)
            {
                throw new Exception("O estoque total não pode estar acima do estoque máximo");
            }

            if (produto.EstoqueTotal < produto.EstoqueMinimo)
            {
                throw new Exception("O estoque total não pode estar abaixo do estoque mínimo");
            }

            ProdutosDAL obj = new ProdutosDAL();
            obj.Alterar(produto);
        }

        public void Excluir(int codigo)
        {
            ProdutosDAL obj = new ProdutosDAL();
            obj.Excluir(codigo);
        }

        public DataTable Listagem(string filtro)
        {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.Listagem(filtro);
        }
    }
}
