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
