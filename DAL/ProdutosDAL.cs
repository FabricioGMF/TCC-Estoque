using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Loja
{
    public class ProdutosDAL
    {
        public ArrayList ProdutosEmFalta()
        {
            SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
            SqlCommand cmd = new SqlCommand("Select * from Produtos Where Estoque < 10", cn);

            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            ArrayList lista = new ArrayList();

            while(dr.Read())
            {
                ProdutoInformation produto = new ProdutoInformation();
                produto.Codigo = Convert.ToInt32(dr["codigo"]);
                produto.Nome = dr["nome"].ToString();
                produto.Estoque = Convert.ToInt32(dr["estoque"]);
                produto.Preco = Convert.ToDecimal(dr["preco"]);
                lista.Add(produto);
            }
            dr.Close();
            cn.Close();

            return lista;
        }

        public void Incluir(ProdutoInformation produto)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Produtos (nome, preco, estoque) values (@nome, @preco, @estoque); select @@IDENTITY";

                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@preco", produto.Preco);
                cmd.Parameters.AddWithValue("@estoque", produto.Estoque);

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

                cmd.CommandText = "update Produtos set nome= @nome, preco= @preco, estoque=@estoque where codigo= @codigo;";

                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@preco", produto.Preco);
                cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
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

                cmd.CommandText = "Delete FROM Produtos WHERE Codigo = @Codigo";
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
            DataTable tabela = new DataTable();
            string strSql;

            if (filtro == "")
            {
                strSql = "select * from Produtos";
            }
            else
            {
                strSql = "Select * from Produtos where nome like '%'" + filtro + "'%'";
            }
            SqlDataAdapter da = new SqlDataAdapter(strSql, Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
