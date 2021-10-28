using Estoque.Modelos;
using System;
using Estoque.DAL;
using System.Data;

namespace BLL
{
    public class ClientesBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            //if (cliente.Nome.Trim().Length == 0) //O nome do cliente é obrigatório
            //{
            //    throw new Exception("O nome/razão social do cliente é obrigatório");
            //}

            cliente.Email = cliente.Email.ToLower(); //Email é sempre em letras minúsculas

            ClientesDAL obj = new ClientesDAL(); //Se tudo está OK, chama a rotina de inserção
            obj.Incluir(cliente);
        }

        public void Alterar(ClienteInformation cliente)
        {
            //if (cliente.Nome.Trim().Length == 0)
            //{
            //    throw new Exception("O nome/razão social do cliente é obrigatório");
            //}

            cliente.Email = cliente.Email.ToLower();

            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(cliente);
        }

        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de exclui-lo");
            }

            ClientesDAL obj = new ClientesDAL();
            obj.Excluir(codigo);
        }

        public DataTable Listagem(string filtro)
        {
            ClientesDAL obj = new ClientesDAL();
            return obj.Listagem(filtro);
        }

        public string Valida_CPFCNPJ(/*campo CPF/CNPJ da entidade Clientes*/)
        {
            return ""; //Implementar
        }
    }
}
