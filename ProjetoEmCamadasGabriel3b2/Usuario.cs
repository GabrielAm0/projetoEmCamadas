using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEmCamadasGabriel3b2
{
   public static class Usuario
    {
        public static int codigo { get; set; }
        public static string email { get; set; }
        public static string senha { get; set; }
        public static Conexao con = new Conexao();

        public static void Criar()
        {
            try
            {
                con.ExecutarComando($"INSERT INTO `usuario`(id, email, senha) VALUES (null,'{email}','{senha}')");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de cadastrar o usuário " + e.Message);
            }
        }

        public static bool Login()
        {
            var usuario = con.ExecutarConsulta($"SELECT * FROM usuario WHERE email = '{email}' && senha = '{senha}'");

            if (usuario.Rows.Count > 0)
            {
                codigo = (int)usuario.Rows[0][0];

                return true;
            }

            return false;
        }

        public static void RedefinirSenha()
        {
            try
            {
                con.ExecutarComando($"UPDATE usuario SET senha='{senha}' WHERE codigo='{codigo}'");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de mudar a senha! " + e.Message);
            }
        }

        public static void Logout()
        {
            codigo = 0;
            email = "";
            senha = "";
        }
    }
}
