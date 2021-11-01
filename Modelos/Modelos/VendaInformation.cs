using System;

namespace Estoque
{
    public class VendaInformation
    {
        private int _codigoVenda;
        public int CodigoVenda
        {
            get { return _codigoVenda; }
            set { _codigoVenda = value; }
        }     

        private DateTime _dataVenda;
        public DateTime DataVenda
        {
            get { return _dataVenda; }
            set { _dataVenda = value; }
        }

        private decimal _faturado;
        public decimal Faturado
        {
            get { return _faturado; }
            set { _faturado = value; }
        }

        private int _codigoCliente;
        public int CodigoCliente
        {
            get { return _codigoCliente; }
            set { _codigoCliente = value; }
        }
    }
}
