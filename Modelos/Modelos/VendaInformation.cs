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
