using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FormControle.Model;


namespace FormControle
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        public void log_into()
        {
            LoginModel model = new LoginModel();
            string email = txt_email.Text;
            string senha = txt_senha.Text;

            model.email = email;
            model.senha = senha;

            bool retorno = model.Authenticate();
            if (retorno)
                this.Hide();
            else
                txt_erro.Text = "Usuário e/ou senha incorretos. Verifique e tente novamente.";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            log_into();
        }
    }
}
