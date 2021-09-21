using System;
using Estoque.Modelos;
using System.Data.SqlClient;
using System.Data;

namespace Estoque.DAL
{
    public class ClientesDAL
    {
        public void Incluir(ClienteInformation cliente)
        { //conexão
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    //nome da stored procedure
                    CommandText = "insere_cliente",
                    //parametros da stored procedure
                    CommandType = CommandType.StoredProcedure
                };
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(pcodigo);
                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.NVarChar, 100)
                {
                    Value = cliente.Nome
                };
                cmd.Parameters.Add(pnome);
                SqlParameter pemail = new SqlParameter("@email", SqlDbType.NVarChar, 100)
                {
                    Value = cliente.Email
                };
                cmd.Parameters.Add(pemail);
                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.NVarChar, 80)
                {
                    Value = cliente.Telefone
                };
                cmd.Parameters.Add(ptelefone);
                SqlParameter pcidade = new SqlParameter("@cidade", SqlDbType.NVarChar, 20)
                {
                    Value = cliente.Cidade
                };
                cmd.Parameters.Add(pcidade);
                SqlParameter puf = new SqlParameter("@UF", SqlDbType.NVarChar, 2)
                {
                    Value = cliente.UF
                };
                cmd.Parameters.Add(puf);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
            }
            catch(SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(ClienteInformation cliente)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,

                    CommandType = CommandType.StoredProcedure,
                    CommandText = "altera_cliente"
                };
                //parametros da stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int)
                {
                    //pcodigo.Direction = ParameterDirection.Output;
                    Value = cliente.Codigo
                };
                cmd.Parameters.Add(pcodigo);
                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.NVarChar, 100)
                {
                    Value = cliente.Nome
                };
                cmd.Parameters.Add(pnome);
                SqlParameter pemail = new SqlParameter("@email", SqlDbType.NVarChar, 100)
                {
                    Value = cliente.Email
                };
                cmd.Parameters.Add(pemail);
                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.NVarChar, 80)
                {
                    Value = cliente.Telefone
                };
                cmd.Parameters.Add(ptelefone);
                SqlParameter pcidade = new SqlParameter("@cidade", SqlDbType.NVarChar, 20)
                {
                    Value = cliente.Cidade
                };
                cmd.Parameters.Add(pcidade);
                SqlParameter puf = new SqlParameter("@UF", SqlDbType.NVarChar, 2)
                {
                    Value = cliente.UF
                };
                cmd.Parameters.Add(puf);

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
                    CommandText = "exclui_cliente"
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
                if(resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o cliente " + codigo);
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
                    CommandText = "seleciona_cliente",
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
