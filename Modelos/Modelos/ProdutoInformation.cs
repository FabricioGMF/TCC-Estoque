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

        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        private decimal _valorCompra;
        public decimal ValorCompra
        {
            get { return _valorCompra; }
            set { _valorCompra = value; }
        }

        private decimal _valorVenda;
        public decimal ValorVenda
        {
            get { return _valorVenda; }
            set { _valorVenda = value; }
        }

        private int _estoque;
        public int Estoque
        {
            get { return _estoque; }
            set { _estoque = value; }
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
    }
}
