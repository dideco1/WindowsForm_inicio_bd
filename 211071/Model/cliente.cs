using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211071.Model
{
    internal class cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int id_cidade { get; set; }
        public DateTime data_nasc { get; set; }
        public double renda { get; set; }
        public string cpf { get; set; }
        public string foto { get; set; }
        public bool venda { get; set; }

        public void incluir()
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySqlCommand("INSERT INTO clientes (nome, id_cidade, data_nasc, renda, cpf, foto, venda)" +
                    "VALUES (@nome, @id_cidade, @data_nasc, @renda, @cpf, @foto, @venda)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@nome", nome);
                Banco.comando.Parameters.AddWithValue("@id_cidade", id_cidade);
                Banco.comando.Parameters.AddWithValue("@data_nasc", data_nasc);
                Banco.comando.Parameters.AddWithValue("@renda", renda);
                Banco.comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.comando.Parameters.AddWithValue("@foto", foto);
                Banco.comando.Parameters.AddWithValue("@venda", venda);

                Banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void alterar()
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySqlCommand("UPDATE clientes SET nome = @nome, id_cidade = @id_cidade, data_nasc = @data_nasc," +
                    "renda = @renda, cpf = @cpf, foto = @foto, venda = @venda WHERE id = @id", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@nome", nome);
                Banco.comando.Parameters.AddWithValue("@id_cidade", id_cidade);
                Banco.comando.Parameters.AddWithValue("@data_nasc", data_nasc);
                Banco.comando.Parameters.AddWithValue("@renda", renda);
                Banco.comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.comando.Parameters.AddWithValue("@foto", foto);
                Banco.comando.Parameters.AddWithValue("@venda", venda);
                Banco.comando.Parameters.AddWithValue("@id", id);

                Banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void excluir()
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySqlCommand("DELETE FROM clientes WHERE id = @id", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@id", id);

                Banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable consultar()
        {
            try
            {
                Banco.comando = new MySqlCommand("SELECT cl.*, ci.nome cidade, ci.uf FROM clientes cl INNER JOIN cidades ci on" +
                    "(ci.id = cl.id_cidade) WHERE cl.nome like @nome ORDER BY cl.nome", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@nome", nome + "%");
                Banco.adaptador = new MySqlDataAdapter(Banco.comando);
                Banco.datatable = new DataTable();
                Banco.adaptador.Fill(Banco.datatable);
                return Banco.datatable;                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
