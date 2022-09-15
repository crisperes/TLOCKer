using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Usuario
    {
        int id_usu;
        string nome_usu;
        string email_usu;
        string telefone_usu;
        string cpf_usu;
        string login_usu;
        string senha_usu;
        int recuperarSenha;

        public int Id_usu { get => id_usu; set => id_usu = value; }
        public string Nome_usu { get => nome_usu; set => nome_usu = value; }
        public string Email_usu { get => email_usu; set => email_usu = value; }
        public string Telefone_usu { get => telefone_usu; set => telefone_usu = value; }
        public string Cpf_usu { get => cpf_usu; set => cpf_usu = value; }
        public string Login_usu { get => login_usu; set => login_usu = value; }
        public string Senha_usu { get => senha_usu; set => senha_usu = value; }
        public int RecuperarSenha { get => recuperarSenha; set => recuperarSenha = value; }
    }
}
