using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Modelos
{
    public class ItemVendaInformation
    {
        private int _codigovenda;
        public int CodigoVenda
        {
            get { return _codigovenda; }
            set { _codigovenda = value; }
        }

        private int _codigoproduto;
        public int CodigoProduto
        {
            get { return _codigoproduto; }
            set { _codigoproduto = value; }
        }

        private int _qtditem;
        public int QtdItem
        {
            get { return _qtditem; }
            set { _qtditem = value; }
        }

        private decimal _valoritem;
        public decimal ValorItem
        {
            get { return _valoritem; }
            set { _valoritem = value; }
        }

        private decimal _totalitem;
        public decimal TotalItem
        {
            get { return _totalitem; }
            set { _totalitem = value; }
        }
    }
}
