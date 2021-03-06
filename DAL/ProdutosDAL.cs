using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Estoque
{
    public class ProdutosDAL
    {
        //Criação da lista de produtos em falta, caso o estoque do produto atinja o estoque mínimo e tenha um estoque de segurança igual a 0:
        public ArrayList ProdutosEmFalta()
        {
            SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
            SqlCommand cmd = new SqlCommand("Select * from Produtos Where estoque = estoque_minimo and estoque_seguranca = 0", cn);

            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            ArrayList lista = new ArrayList();

            while(dr.Read())
            {
                ProdutoInformation produto = new ProdutoInformation();
                produto.Codigo = Convert.ToInt32(dr["codigo"]);
                produto.Descricao = dr["descricao"].ToString();
                produto.ValorCompra = Convert.ToDecimal(dr["valorcompra"]);
                produto.ValorVenda = Convert.ToDecimal(dr["valorvenda"]);
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

        //Operação do uso do estoque de segurança, caso o estoque seja igual ao estoque mínimo:
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

        //Operação de Inclusão:
        public void Incluir(ProdutoInformation produto)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    //nome da stored procedure
                    CommandText = "insere_produto",
                    //parametros da stored procedure
                    CommandType = CommandType.StoredProcedure
                };
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdescricao = new SqlParameter("@descricao", SqlDbType.NVarChar, 100)
                {
                    Value = produto.Descricao
                };
                cmd.Parameters.Add(pdescricao);

                SqlParameter pvalorcompra = new SqlParameter("@valorcompra", SqlDbType.Decimal)
                {
                    Precision = 10,
                    Scale = 2,
                    Value = produto.ValorCompra
                };
                cmd.Parameters.Add(pvalorcompra);

                SqlParameter pvalorvenda = new SqlParameter("@valorvenda", SqlDbType.Decimal)
                {
                    Precision = 10,
                    Scale = 2,
                    Value = produto.ValorVenda
                };
                cmd.Parameters.Add(pvalorvenda);

                SqlParameter pestoque = new SqlParameter("@estoque", SqlDbType.Int)
                {
                    Value = produto.Estoque
                };
                cmd.Parameters.Add(pestoque);

                SqlParameter pestoqueminimo = new SqlParameter("@estoque_minimo", SqlDbType.Int)
                {
                    Value = produto.EstoqueMinimo
                };
                cmd.Parameters.Add(pestoqueminimo);

                SqlParameter pestoquemaximo = new SqlParameter("@estoque_maximo", SqlDbType.Int)
                {
                    Value = produto.EstoqueMaximo
                };
                cmd.Parameters.Add(pestoquemaximo);

                SqlParameter pestoqueseguranca = new SqlParameter("@estoque_seguranca", SqlDbType.Int)
                {
                    Value = produto.EstoqueSeguranca
                };
                cmd.Parameters.Add(pestoqueseguranca);

                cn.Open();
                cmd.ExecuteNonQuery();

                produto.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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
        public void Excluir(int codigo)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,

                    CommandType = CommandType.StoredProcedure,
                    CommandText = "exclui_produto"
                };
                //parametros da stored procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int)
                {
                    //pcodigo.Direction = ParameterDirection.Output;
                    Value = codigo
                };
                cmd.Parameters.Add(pcodigo);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o produto " + codigo);
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

        //Operação de listagem de um produto, de acordo com o filtro:
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
