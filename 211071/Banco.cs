﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _211071
{
    public class Banco
    {
        // Variável responsável pela conexão c/ o banco
        public static MySqlConnection conexao;

        // Variável responsável a orientar os comandos a serem executados
        public static MySqlCommand comando;

        // Variável responsável por inserir dados numa table
        public static MySqlDataAdapter adaptador;

        // Variável responsável por ligar o banco em controles com a propriedade DataSource
        public static DataTable datatable;

        public static void AbrirConexao()
        {
            try
            {
                // Dá os parametros para a conexão ser feita: servidor, porta e senha, respectivamente
                conexao = new MySqlConnection("server = localhost;port = 3307;pwd = etecjau");

                // Abre a conexão
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void FecharConexao()
        {
            try
            {
                // Fecha conexão com o banco
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CriarBanco()
        {
            try
            {
                // abre conexão
                AbrirConexao();

                // atribui à variavel o comando: criar banco "vendas" se ele já não existir; usar vendas;
                // através da conexão: conexao;
                comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas;", conexao);

                // executa o comando no MySQL
                comando.ExecuteNonQuery();

                // fecha conexão
                FecharConexao();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}