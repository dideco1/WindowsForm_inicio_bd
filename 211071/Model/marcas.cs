using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211071.Model
{
    internal class marcas
    {
        public int id { get; set; }
        public string marca { get; set; }
        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.comando = new MySqlCommand("INSERT INTO marcas (marca) VALUES (@marca)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("marca", marca);
                Banco.comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.comando = new MySqlCommand("UPDATE marcas SET marca=@marca WHERE id=@id", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@marca2", marca);
                Banco.comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("SELECT * FROM marcas WHERE marca like @marca " +
                    "ORDER BY marca", Banco.conexao);

                Banco.comando.Parameters.AddWithValue("@nome", marca + "%");
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
        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.comando = new MySqlCommand("DELETE FROM marcas WHERE id = @id", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@id", id);
                Banco.comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
