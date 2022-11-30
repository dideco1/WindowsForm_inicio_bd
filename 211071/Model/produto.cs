using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211071.Model
{
    internal class produto
    {
        public int id { get; set; }
        public char descricao { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }
        public decimal estoque { get; set; }
        public decimal valorVenda { get; set; }
        public string foto { get; set; }

        public DataTable consultar()
        {
            try
            {
                Banco.comando = new MySqlCommand("SELECT p.*, m.marca, c.categoria FROM produtos p inner join marcas m on (m.id = p.idMarca) inner join categorias c ON" +
                    "(c.id = p.idCategoria) WHERE p.descricao like @descricao ORDER BY p.descricao", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@descricao", descricao + "%");
                Banco.adaptador = new MySqlDataAdapter(Banco.comando);
                Banco.datatable = new DataTable();
                Banco.adaptador.Fill(Banco.datatable);
                return Banco.datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
