using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using FormControle.Model;

namespace FormControle.DAL
{
    internal class LoginDAL
    {
        connMySQL conection = new connMySQL();
        MySqlCommand stmt = new MySqlCommand();

        public LoginDAL()
        {
            stmt.Connection = conection.toConnect();
        }

        public MySqlDataReader selectByUserForLogin(LoginModel model)
        {
            stmt.CommandText = "SELECT * FROM Funcionario WHERE email = @email AND senha = sha1(@senha)";
            stmt.Parameters.AddWithValue("@email", model.email);
            stmt.Parameters.AddWithValue("@senha", model.senha);

            return stmt.ExecuteReader();
        }
    }
}
