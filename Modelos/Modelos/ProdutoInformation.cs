using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    public class ProdutoInformation
    {
        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private int _estoque;
        public int Estoque
        {
            get { return _estoque; }
            set { _estoque = value; }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private decimal _preco;
        public decimal Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        private int _estoqueMinimo;
        public int EstoqueMinimo
        {
            get { return _estoqueMinimo; }
            set { _estoqueMinimo = value; }
        }

        private int _estoqueMaximo;
        public int EstoqueMaximo
        {
            get { return _estoqueMaximo; }
            set { _estoqueMaximo = value; }
        }

        private int _estoqueSeguranca;
        public int EstoqueSeguranca
        {
            get { return _estoqueSeguranca; }
            set { _estoqueSeguranca = value; }
        }

        private int _estoqueTotal;
        public int EstoqueTotal
        {
            get { return _estoqueTotal; }
            set { _estoqueTotal = value; }
        }
    }
}
