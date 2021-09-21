using Estoque;
using System.Data;

namespace BLL
{
    public class VendasBLL
    {
        private VendasDAL objDAL;

        public VendasBLL()
        {
            objDAL = new VendasDAL();
        }

        public DataTable ListaDeClientes
        {
            get
            {
                return objDAL.ListaDeClientes;
            }
        }

        public DataTable ListaDeProdutos
        {
            get
            {
                return objDAL.ListaDeProdutos;
            }
        }

        public void Incluir(VendaInformation venda)
        {
            objDAL.Incluir(venda);
        }
    }
}
