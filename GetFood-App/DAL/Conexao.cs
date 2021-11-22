using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFood_App.DAL
{
    public class Conexao
    {

        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Data Source=LAPTOP-0MNCEOGP\SQLEXPRESS;Initial Catalog=GetFood-App;Integrated Security=True";
        }

        public SqlConnection Conecta()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();

            }
        }

    }
}
