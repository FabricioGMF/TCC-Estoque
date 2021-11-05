using Estoque.Modelos;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Estoque.DAL
{
    public class ItemVendaDAL
    {
        //Lista de Itens:
        public ArrayList ListaItens()
        {
            SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
            SqlCommand cmd = new SqlCommand("Select * from Item_Vendas", cn);

            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            ArrayList lista = new ArrayList();

            while (dr.Read())
            {
                ItemVendaInformation itemVenda = new ItemVendaInformation();
                itemVenda.CodigoVenda = Convert.ToInt32(dr["codigoVenda"]);
                itemVenda.CodigoProduto = Convert.ToInt32(dr["codigoProduto"]);
                itemVenda.QtdItem = Convert.ToInt32(dr["qtditem"]);
                itemVenda.ValorItem = Convert.ToDecimal(dr["valoritem"]);
                itemVenda.TotalItem = Convert.ToDecimal(dr["totalitem"]);
                lista.Add(itemVenda);
            }
            dr.Close();
            cn.Close();

            return lista;
        }

        //Operação de Inclusão:
        public void Incluir(ItemVendaInformation itemVenda)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Inserir ItemVenda";
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "set identity_insert item_Vendas on;" + 
                                  "insert into item_Vendas(codigoVenda, codigoProduto, qtd_item, valor_item, total_item) values (@codigoVenda, @codigoProduto, @qtditem, @valoritem, @totalitem);" + 
                                  "set identity_insert item_Vendas off;";

                cmd.Parameters.AddWithValue("@codigoVenda", itemVenda.CodigoVenda);
                cmd.Parameters.AddWithValue("@codigoProduto", itemVenda.CodigoProduto);
                cmd.Parameters.AddWithValue("@qtditem", itemVenda.QtdItem);
                cmd.Parameters.AddWithValue("@valoritem", itemVenda.ValorItem);
                cmd.Parameters.AddWithValue("@totalitem", itemVenda.TotalItem);

                cn.Open();
                cmd.ExecuteNonQuery();

                //cn.ConnectionString = Dados.StringDeConexao;
                ////command
                //SqlCommand cmd = new SqlCommand
                //{
                //    Connection = cn,
                //    //nome da stored procedure
                //    CommandText = "insere_itemVenda",
                //    //parametros da stored procedure
                //    CommandType = CommandType.StoredProcedure
                //};
                //SqlParameter pcodigovenda = new SqlParameter("@codigoVenda", SqlDbType.Int)
                //{
                //    Direction = ParameterDirection.Output
                //};
                //cmd.Parameters.Add(pcodigovenda);

                //SqlParameter pcodigoproduto = new SqlParameter("@codigoProduto", SqlDbType.Int)
                //{
                //    Value = itemVenda.CodigoProduto
                //};
                //cmd.Parameters.Add(pcodigoproduto);

                //SqlParameter pqtditem = new SqlParameter("@qtditem", SqlDbType.Int)
                //{
                //    Value = itemVenda.QtdItem
                //};
                //cmd.Parameters.Add(pqtditem);

                //SqlParameter pvaloritem = new SqlParameter("@valoritem", SqlDbType.Decimal)
                //{
                //    Precision = 10,
                //    Scale = 2,
                //    Value = itemVenda.ValorItem
                //};
                //cmd.Parameters.Add(pvaloritem);

                //SqlParameter ptotalitem = new SqlParameter("@totalitem", SqlDbType.Decimal)
                //{
                //    Precision = 10,
                //    Scale = 2,
                //    Value = itemVenda.TotalItem
                //};
                //cmd.Parameters.Add(ptotalitem);

                //cn.Open();
                //cmd.ExecuteNonQuery();

                //itemVenda.CodigoVenda = (Int32)cmd.Parameters["@codigoVenda"].Value;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        //Operação de Alteração:
        public void Alterar(ItemVendaInformation itemVenda)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Alterar ItemVenda";
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update produtos set codigoProduto= @codigoProduto, qtditem= @qtditem, valoritem=@valoritem, totalitem=@totalitem where codigoVenda= @codigoVenda;";

                cmd.Parameters.AddWithValue("@codigoProduto", itemVenda.CodigoProduto);
                cmd.Parameters.AddWithValue("@qtditem", itemVenda.QtdItem);
                cmd.Parameters.AddWithValue("@valoritem", itemVenda.ValorItem);
                cmd.Parameters.AddWithValue("@totalitem", itemVenda.TotalItem);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        //Operação de Exclusão:
        public void Excluir(int codigoVenda)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,

                    CommandType = CommandType.StoredProcedure,
                    CommandText = "exclui_itemVenda"
                };
                //parametros da stored procedure
                SqlParameter pcodigovenda = new SqlParameter("@codigoVenda", SqlDbType.Int)
                {
                    //pcodigo.Direction = ParameterDirection.Output;
                    Value = codigoVenda
                };
                cmd.Parameters.Add(pcodigovenda);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o produto " + codigoVenda);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
