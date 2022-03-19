using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoginWPFK020.Datos
{
    class LoginDao
    {
        private static const NOMBRE_ARCHIVO = "C:\Usuario\jonathan\Documentos\usuarios.txt";

        public string Password { get; internal set; }
        public string Username { get; internal set; }

        public int readFile(string usrname, string password)
        {
            Usuario user = null;
            try
            {
                StreamReader sr = StreamReader(NOMBRE_ARCHIVO);
                string line = sr.ReadLine();
                int contador 1;
                user = new Usuario();
                while (line !=null)
                {
                    if (contador == 1)
                    {
                        user.Username = line;
                    }
                    if(contador == 2)
                    {
                        user.Password = line;
                    }
                    line = sr.ReadLine();
                    contador++;
                }
            }catch (Exception)
            {

            }
            return user;
        }

        internal Usuario ReadFile()
        {
            throw new NotImplementedException();
        }

        private StreamReader StreamReader(NOMBRE_ARCHIVO NOMBRE_ARCHIVO)
        {
            throw new NotImplementedException();
        }
    }
}
