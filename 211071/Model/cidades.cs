using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace _211071.Model
{
    internal class cidades
    {
        int id { get; set; }
        string nome { get; set; }
        int uf { get; set; }

        public void incluir()
        {
            Banco.AbrirConexao();
            // Da o comando desejado e logo em seguida qual conexão será utilizada para executar a instrução
            Banco.comando = new MySqlCommand("INSERT INTO cidades(nome,uf) VALUES (@nome, @uf)", Banco.conexao);
            // Da o valor dos parâmetros ditos no comando acima
            Banco.comando.Parameters.AddWithValue("@nome", nome);
            Banco.comando.Parameters.AddWithValue("@uf", uf);

            Banco.comando.ExecuteNonQuery();
            Banco.FecharConexao();
        }
    }
}
