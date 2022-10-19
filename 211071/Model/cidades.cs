using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace _211071.Model
{
    public class cidades
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }

        public void incluir()
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void alterar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("UPDATE cidades SET nome = @nome, uf = @uf WHERE id = @id", Banco.conexao);

                Banco.comando.Parameters.AddWithValue("@nome", nome);
                Banco.comando.Parameters.AddWithValue("@uf", uf);
                Banco.comando.Parameters.AddWithValue("@id", id);
                Banco.comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void excluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("DELETE FROM cidades WHERE id = @id", Banco.conexao);

                Banco.comando.Parameters.AddWithValue("@id", id);
                Banco.comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("SELECT * FROM cidades WHERE nome like @nome" + "ORDER BY nome", Banco.conexao);

                Banco.comando.Parameters.AddWithValue("@nome", nome + "%");
                Banco.adaptador = new MySqlDataAdapter(Banco.comando);
                Banco.datatable = new DataTable();
                Banco.adaptador.Fill(Banco.datatable);
                Banco.FecharConexao();
                return Banco.datatable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
