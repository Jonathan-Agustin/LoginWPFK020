using LoginWPFK020.Datos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginWPFK020.Negocio
{
    class LoginService
    {
        string usernameValido = "admin";
        string passwordValido = "nimda";
        private object usuario;

        public bool checkArchivoTexto(string username, string password)
        {
            if (usernameValido == username &&
                passwordValido == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckArchivoTexto(string username, string password)
        {
            LoginDao loginDao = new LoginDao();
            Usuario usu = loginDao.ReadFile();
            if(usuario !=null)
            {
                if(loginDao.Username == username &&
                    loginDao.Password == password)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
