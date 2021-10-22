using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjetoEmCamadasGabriel3b2
{
   public class Unidade
    {
        public int codigo { get; set; }
        public string nomeunidade { get; set; }
        public  int codigo_sabor { get; set; }

        public Conexao con;

        public Unidade()
        {
            con = new Conexao();
        }

        public void Criar()
        {
            try
            {
                con.ExecutarComando($"INSERT INTO `unidade`(`codigo`, `nome_unidade`, `codigo_sabor`) VALUES (null,'{nomeunidade}','{codigo_sabor}')");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de cadastrar um unidade " + e.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                return con.ExecutarConsulta($"SELECT * FROM `unidade`");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de listar os unidadees " + e.Message);
            }
        }

        public void Editar()
        {
            try
            {
                con.ExecutarComando($"UPDATE `unidade` SET `nome_unidade` = '{nomeunidade}',codigo_sabor='{codigo_sabor}' WHERE codigo = '{codigo}'");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de ediar o unidade " + e.Message);
            }
        }

        public void Deletar()
        {
            try
            {
                con.ExecutarComando($"DELETE FROM `unidade` WHERE `codigo` = '{codigo}'");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de deletar um unidade " + e.Message);
            }
        }
    }

}

