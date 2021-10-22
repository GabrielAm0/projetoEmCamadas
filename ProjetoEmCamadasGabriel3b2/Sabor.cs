using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjetoEmCamadasGabriel3b2
{
    public class Sabor
    {
        public int codigo { get; set; }
        public string Nome_sabor { get; set; }
        public string tipo { get; set; }

        public Conexao con;

        public Sabor()
        {
            con = new Conexao();
        }

        public void Criar()
        {
            try
            {
                con.ExecutarComando($"INSERT INTO `sabor`(`codigo`, `Nome_sabor`, `tipo`) VALUES (null,'{Nome_sabor}','{tipo}')");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de cadastrar um sabor " + e.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                return con.ExecutarConsulta($"SELECT * FROM `sabor`");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de listar os sabores " + e.Message);
            }
        }

        public void Editar()
        {
            try
            {
                con.ExecutarComando($"UPDATE `sabor` SET `Nome_sabor` = '{Nome_sabor}',tipo='{tipo}' WHERE codigo = '{codigo}'");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de ediar o sabor " + e.Message);
            }
        }

        public void Deletar()
        {
            try
            {
                con.ExecutarComando($"DELETE FROM `sabor` WHERE `codigo` = '{codigo}'");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de deletar um sabor " + e.Message);
            }
        }
    }
}
