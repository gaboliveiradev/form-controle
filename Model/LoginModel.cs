﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace FormControle.Model
{
    internal class LoginModel
    {
        public string email, senha;
        public MySqlDataReader dr;

    }
}