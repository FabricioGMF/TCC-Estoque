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

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100)
                {
                    Value = cliente.Nome
                };
                cmd.Parameters.Add(pnome);

                SqlParameter pcpfcnpj = new SqlParameter("@cpfcnpj", SqlDbType.VarChar, 20)
                {
                    Value = cliente.CPFCNPJ
                };
                cmd.Parameters.Add(pcpfcnpj);

                SqlParameter plogradouro = new SqlParameter("@logradouro", SqlDbType.VarChar, 80)
                {
                    Value = cliente.Logradouro
                };
                cmd.Parameters.Add(plogradouro);

                SqlParameter pbairro = new SqlParameter("@bairro", SqlDbType.VarChar, 50)
                {
                    Value = cliente.Bairro
                };
                cmd.Parameters.Add(pbairro);

                SqlParameter pcidade = new SqlParameter("@cidade", SqlDbType.VarChar, 50)
                {
                    Value = cliente.Cidade
                };
                cmd.Parameters.Add(pcidade);

                SqlParameter puf = new SqlParameter("@UF", SqlDbType.VarChar, 2)
                {
                    Value = cliente.UF
                };
                cmd.Parameters.Add(puf);

                SqlParameter pcep = new SqlParameter("@CEP", SqlDbType.VarChar, 8)
                {
                    Value = cliente.CEP
                };
                cmd.Parameters.Add(pcep);

                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100)
                {
                    Value = cliente.Email
                };
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.VarChar, 11)
                {
                    Value = cliente.Telefone
                };
                cmd.Parameters.Add(ptelefone);

                SqlParameter ptelefone2 = new SqlParameter("@telefone2", SqlDbType.VarChar, 11)
                {
                    Value = cliente.Telefone2
                };
                cmd.Parameters.Add(ptelefone2);

                SqlParameter pdatacadastro = new SqlParameter("@datacadastro", SqlDbType.DateTime)
                {
                    Value = cliente.DataCadastro
                };
                cmd.Parameters.Add(pdatacadastro);

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

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100)
                {
                    Value = cliente.Nome
                };
                cmd.Parameters.Add(pnome);

                SqlParameter pcpfcnpj = new SqlParameter("@cpfcnpj", SqlDbType.VarChar, 20)
                {
                    Value = cliente.CPFCNPJ
                };
                cmd.Parameters.Add(pcpfcnpj);

                SqlParameter plogradouro = new SqlParameter("@logradouro", SqlDbType.VarChar, 80)
                {
                    Value = cliente.Logradouro
                };
                cmd.Parameters.Add(plogradouro);

                SqlParameter pbairro = new SqlParameter("@bairro", SqlDbType.VarChar, 50)
                {
                    Value = cliente.Bairro
                };
                cmd.Parameters.Add(pbairro);

                SqlParameter pcidade = new SqlParameter("@cidade", SqlDbType.VarChar, 50)
                {
                    Value = cliente.Cidade
                };
                cmd.Parameters.Add(pcidade);

                SqlParameter puf = new SqlParameter("@UF", SqlDbType.VarChar, 2)
                {
                    Value = cliente.UF
                };
                cmd.Parameters.Add(puf);

                SqlParameter pcep = new SqlParameter("@CEP", SqlDbType.VarChar, 8)
                {
                    Value = cliente.CEP
                };
                cmd.Parameters.Add(pcep);

                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100)
                {
                    Value = cliente.Email
                };
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.VarChar, 11)
                {
                    Value = cliente.Telefone
                };
                cmd.Parameters.Add(ptelefone);

                SqlParameter ptelefone2 = new SqlParameter("@telefone2", SqlDbType.VarChar, 11)
                {
                    Value = cliente.Telefone2
                };
                cmd.Parameters.Add(ptelefone2);

                SqlParameter pdatacadastro = new SqlParameter("@datacadastro", SqlDbType.DateTime)
                {
                    Value = cliente.DataCadastro
                };
                cmd.Parameters.Add(pdatacadastro);

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
