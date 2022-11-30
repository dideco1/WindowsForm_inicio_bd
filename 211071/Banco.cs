using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

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
                string server = "localhost";
                string porta = "3307";
                string usuario = "root";
                string senha = "etecjau";
                // Dá os parametros para a conexão ser feita: servidor, porta e senha, respectivamente
                conexao = new MySqlConnection("server=" + server + ";port=" + porta + ";uid=" + usuario + ";pwd=" + senha);

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

                // atribui à variavel o comando de criar o banco de dados e a tabela cidades;
                comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas;" +
                    "CREATE TABLE IF NOT EXISTS cidades(id integer auto_increment primary key, nome varchar(40)," +
                    "uf char(02))", conexao);

                // executa o comando no MySQL
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS marcas(id integer auto_increment primary key, marca char(20))", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS categorias(id integer auto_increment primary key, categoria char(20))", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS clientes(id integer auto_increment primary key, nome char(40)," +
                    "id_cidade integer, data_nasc date, renda decimal(10,2), cpf char(14), foto varchar(100), venda boolean)", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS produtos(id integer auto_increment primary key, descricao char(40), idCategoria integer, " +
                    "idMarca integer, estoque decimal(10, 3), valorVenda decimal(10, 2), foto varchar(100))", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS VendaCab(id integer auto_increment primary key, idCliente int, data date, total decimal(10,2))", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS VendaDet(id integer auto_increment primary key, idVendaCab int, idProduto int, qntd decimal(10, 3)," +
                    "valorUnitario decimal(10, 2))", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS caixa(id integer auto_increment primary key, idVendaCab int," +
                    "dinheiro decimal(10, 2), pix decimal(10, 2), cartao decimal(10, 2), cheque decimal(10, 2), boleto decimal (10, 2))", conexao);
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
