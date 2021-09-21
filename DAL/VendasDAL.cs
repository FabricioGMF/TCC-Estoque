using System;
using System.Data;
using System.Data.SqlClient;

namespace Loja
{
    public class VendasDAL
    {
        public DataTable ListaDeProdutos
        {
            get
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select * from produtos", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }

        public DataTable ListaDeClientes
        {
            get
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select * from cliente", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }

        public void Incluir(VendaInformation venda)
        {
            SqlConnection cn = new SqlConnection();
            SqlTransaction t = null;

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = cn;
                cmd1.CommandText = "insert into Vendas (CodigoCliente, CodigoProduto, Data_Venda, Quantidade, Faturado) VALUES (@CodigoCliente, @CodigoProduto, @Data, @Quantidade, @Faturado); select @@IDENTITY";

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = cn;
                cmd2.CommandText= @"Update Produtos Set estoque = Estoque - @Quantidade where Codigo = @CodigoProduto";

                cn.Open();

                t = cn.BeginTransaction(IsolationLevel.Serializable);

                cmd1.Transaction = t;
                cmd2.Transaction = t;

                cmd1.Parameters.AddWithValue("@CodigoCliente", venda.CodigoCliente);
                cmd1.Parameters.AddWithValue("@CodigoProduto", venda.CodigoProduto);
                cmd1.Parameters.AddWithValue("@Data_Venda", venda.DataVenda);
                cmd1.Parameters.AddWithValue("@Quantidade", venda.Quantidade);
                cmd1.Parameters.AddWithValue("@Faturado", venda.Faturado);

                cmd2.Parameters.AddWithValue("@CodigoProduto", venda.CodigoProduto);
                cmd2.Parameters.AddWithValue("@Quantidade", venda.Quantidade);

                venda.Codigo = Convert.ToInt32(cmd2.ExecuteScalar());
                cmd2.ExecuteNonQuery();

                t.Commit();
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
