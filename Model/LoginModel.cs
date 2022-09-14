using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using FormControle.DAL;
using FormControle.View.Modules.Principal;

namespace FormControle.Model
{
    internal class LoginModel
    {
        public string id, email, senha;
        public MySqlDataReader dr;

        public bool Authenticate()
        {
            LoginDAL dal = new LoginDAL();
            dr = dal.selectByUserForLogin(this);

            while(dr.Read())
            {
                id = dr.GetString("id");
                email = dr.GetString("email");
            }

            frm_principal principal = new frm_principal();
            if (id != null)
            {
                principal.Show();
                return true;
            } else
            {
                return false;
            }
        }

    }
}
