using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211071.Model
{
    internal class VendaDet
    {
        public int id { get; set; }
        public int idVendaCab { get; set; }
        public int idProduto { get; set; }
        public double qntd { get; set; }
        public double valorUnitario { get; set; }

        public void incluir()
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySqlCommand("INSERT INTO vendaDet (idVendaCab, idProduto, qntd, valorUnitario) VALUES (@idVendaCab, @idProduto, @qntd, @valorUnitario",
                    Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@idVendaCab", idVendaCab);
                Banco.comando.Parameters.AddWithValue("@idProduto", idProduto);
                Banco.comando.Parameters.AddWithValue("@qntd", qntd);
                Banco.comando.Parameters.AddWithValue("@valorUnitario", valorUnitario);
                Banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
