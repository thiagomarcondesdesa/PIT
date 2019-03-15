using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIT.Models
{
    public class Usuario
    {

        int _id;
        string _login;
        string _senha;

        public Usuario(int id, string login, string senha)
        {
            Id = id;
            Login = login;
            Senha = senha;
        }

        public Usuario()
        {
            Id = 0;
        }

        public int Id { get => _id; set => _id = value; }
        public string Login { get => _login; set => _login = value; }
        public string Senha { get => _senha; set => _senha = value; }


        public bool Logar(Usuario u, out string msg)
        {
            msg = "";
            if ((u.Login=="admin") && (u.Senha == "admin"))
            {
                msg = "Login correto";
                return true;
            }
            else
            {
                msg = "Login incorreto";
                return false;
            }        
        }


    }
}
