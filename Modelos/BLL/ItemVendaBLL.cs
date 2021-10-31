using Estoque.DAL;
using Estoque.Modelos;
using System.Collections;

namespace BLL
{
    public class ItemVendaBLL
    {
        //Lista de Itens da Venda:
        public ArrayList ListaItens()
        {
            ItemVendaDAL obj = new ItemVendaDAL();
            return obj.ListaItens();
        }

        //Regras de negócio na operação de inclusão de produto:
        public void Incluir(ItemVendaInformation itemVenda)
        {
            ItemVendaDAL obj = new ItemVendaDAL();
            obj.Incluir(itemVenda);
        }

        //Regras de negócio na operação de alteração de produto:
        public void Alterar(ItemVendaInformation itemVenda)
        {
            ItemVendaDAL obj = new ItemVendaDAL();
            obj.Alterar(itemVenda);
        }

        //Operação de exclusão de produto:
        public void Excluir(int codigoVenda)
        {
            ItemVendaDAL obj = new ItemVendaDAL();
            obj.Excluir(codigoVenda);
        }
    }
}
