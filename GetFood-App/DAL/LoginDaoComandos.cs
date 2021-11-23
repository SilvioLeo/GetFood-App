using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFood_App.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String menssagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        DataTable dt = new DataTable();



        public bool VerificarLogin(String email, String senha)
        {
            //Comados sql para verificar no banco se tem 
            cmd.CommandText = "SELECT * FROM logins WHERE email = @email AND senha = @senha";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conecta();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.menssagem = "Erro de Banco de dados";
            }
            
            return tem;
        }

        public String Cadastrar(String email, String senha, String confSenha)
        {
            tem = false;
            //Comandos para inserir no banco
            if(senha.Equals(confSenha))
            {
                cmd.CommandText = "INSERT INTO logins VALUES (@e,@s)";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.Conecta();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.menssagem = "Cadastrado com sucesso!!!";
                    tem = true;


                }
                catch (SqlException)
                {

                    this.menssagem = "Erro com o banco de dados!!!";
                }

            }
            else
            {
                this.menssagem = "Senhas não correspondem!!!";

            }
            
            return menssagem;
        }

        public string CadastrarAlimentos(string id, string alimento, string quantidade, string dataFabricacao, string dataVencimento)
        {
            tem = false;
            cmd.CommandText = "INSERT INTO tabela_Alimentos VALUES(@id,@alin,@quant,@dateF,@dateV)";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@alin", alimento);
            cmd.Parameters.AddWithValue("@quant", quantidade);
            cmd.Parameters.AddWithValue("@dateF", dataFabricacao);
            cmd.Parameters.AddWithValue("@dateV", dataVencimento);

            try
            {
                cmd.Connection = con.Conecta();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                tem = true;


            }
            catch (SqlException)
            {
                this.menssagem = "Erro no banco de dados";
                
            }
            return menssagem;
        }

    }
}
