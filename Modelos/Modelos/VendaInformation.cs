using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    public class VendaInformation
    {
        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private int _codigoCliente;
        public int CodigoCliente
        {
            get { return _codigoCliente; }
            set { _codigoCliente = value; }
        }

        private int _codigoProduto;
        public int CodigoProduto
        {
            get { return _codigoProduto; }
            set { _codigoProduto = value; }
        }

        private DateTime _dataVenda;
        public DateTime DataVenda
        {
            get { return _dataVenda; }
            set { _dataVenda = value; }
        }

        private bool _faturado;
        public bool Faturado
        {
            get { return _faturado; }
            set { _faturado = value; }
        }

        private string _nomeCliente;
        public string NomeCliente
        {
            get { return _nomeCliente; }
            set { _nomeCliente = value; }
        }

        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
    }
}
