using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Estoque
{
    public class ProdutosDAL
    {
        public ArrayList ProdutosEmFalta()
        {
            SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
            SqlCommand cmd = new SqlCommand("Select * from Produtos Where Estoque = Estoque_Minimo and Estoque_Seguranca = 0", cn);

            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            ArrayList lista = new ArrayList();

            while(dr.Read())
            {
                ProdutoInformation produto = new ProdutoInformation();
                produto.Codigo = Convert.ToInt32(dr["codigo"]);
                produto.Descricao = dr["descricao"].ToString();
                produto.ValorCompra = Convert.ToDecimal(dr["valor_compra"]);
                produto.ValorVenda = Convert.ToDecimal(dr["valor_venda"]);
                produto.Estoque = Convert.ToInt32(dr["estoque"]);
                produto.EstoqueMinimo = Convert.ToInt32(dr["estoque_minimo"]);
                produto.EstoqueMaximo = Convert.ToInt32(dr["estoque_maximo"]);
                produto.EstoqueSeguranca = Convert.ToInt32(dr["estoque_seguranca"]);
                lista.Add(produto);
            }
            dr.Close();
            cn.Close();

            return lista;
        }

        public int Uso_EstoqueSeguranca(ProdutoInformation produto)
        {
            if (produto.Estoque == produto.EstoqueMinimo)
            {
                //SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
                //SqlCommand cmd = new SqlCommand("Update Produtos set Estoque = Estoque + Estoque_Seguranca, Estoque_Seguranca = 0 where Estoque = Estoque * 0.1", cn);

                produto.Estoque += produto.EstoqueSeguranca; //produto.Estoque = produto.Estoque + produto.EstoqueSeguranca;
                produto.EstoqueSeguranca = 0;
            }
            return (int)produto.Estoque;
        }

        public void Incluir(ProdutoInformation produto)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into produtos (descricao, valorcompra, valorvenda, estoque, estoque_minimo, estoque_maximo, estoque_seguranca) values (@descricao, @valorcompra, @valorvenda, @estoque, @estoque_minimo, @estoque_maximo, @estoque_seguranca); select @@IDENTITY";

                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@valorcompra", produto.ValorCompra);
                cmd.Parameters.AddWithValue("@valorvenda", produto.ValorVenda);
                cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
                cmd.Parameters.AddWithValue("@estoque_minimo", produto.EstoqueMinimo);
                cmd.Parameters.AddWithValue("@estoque_maximo", produto.EstoqueMaximo);
                cmd.Parameters.AddWithValue("@estoque_seguranca", produto.EstoqueSeguranca);
                
                cn.Open();
                produto.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ProdutoInformation produto)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Alterar Produto";
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update produtos set descricao= @descricao, valorcompra= @valorcompra, valorvenda=@valorvenda, estoque=@estoque, estoque_minimo=@estoque_minimo, estoque_maximo=@estoque_maximo, estoque_seguranca=@estoque_seguranca where codigo= @codigo;";

                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@valorcompra", produto.ValorCompra);
                cmd.Parameters.AddWithValue("@valorvenda", produto.ValorVenda);
                cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
                cmd.Parameters.AddWithValue("@estoque_minimo", produto.EstoqueMinimo);
                cmd.Parameters.AddWithValue("@estoque_maximo", produto.EstoqueMaximo);
                cmd.Parameters.AddWithValue("@estoque_seguranca", produto.EstoqueSeguranca);
                cmd.Parameters.AddWithValue("@Codigo", produto.Codigo);

                // cmd.Parameters.Add("@valorEstoque", SqlDbType.Int);
                // cmd.Parameters["@valorEstoque"].Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

               // decimal valorEstoque = Convert.ToDecimal(cmd.Parameters["@valorestoque"]);

                //if(valorEstoque < 500)
                //{
                //    throw new Exception("Atenção! Valor baixo no estoque.");
                //}
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

        public void Excluir(int codigo)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "Delete FROM produtos WHERE Codigo = @Codigo";
                cmd.CommandType = CommandType.Text;

                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);

                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                
                int resultado = cmd.ExecuteNonQuery();
                               
                if (resultado != 1)
                {
                    throw new Exception("Atenção! Valor baixo no estoque.");
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

        public DataTable Listagem(string filtro)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tabela = new DataTable();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //adapter
                da.SelectCommand = new SqlCommand
                {
                    CommandText = "seleciona_produto",
                    Connection = cn,
                    CommandType = CommandType.StoredProcedure
                };
                //parametros da stored procedure
                SqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("@filtro", SqlDbType.Text);
                pfiltro.Value = filtro;

                da.Fill(tabela);

                return tabela;
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
