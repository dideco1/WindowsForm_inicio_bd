using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211071.Model
{
    internal class caixa
    {
        public int id { get; set; }
        public int idVendaCab { get; set; }
        public double dinheiro { get; set; }
        public double pix { get; set; }
        public double cartao { get; set; }
        public double cheque { get; set; }
        public double boleto { get; set; }

        public void incluir()
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySqlCommand("INSERT INTO caixa (idVendaCab, dinheiro, pix, cartao, cheque, boleto)" +
                    "VALUES (@idVendaCab, @dinheiro, @pix, @cartao, @cheque, @boleto)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@idVendaCab", idVendaCab);
                Banco.comando.Parameters.AddWithValue("@dinheiro", dinheiro);
                Banco.comando.Parameters.AddWithValue("@pix", pix);
                Banco.comando.Parameters.AddWithValue("@cartao", cartao);
                Banco.comando.Parameters.AddWithValue("@cheque", cheque);
                Banco.comando.Parameters.AddWithValue("@boleto", boleto);
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
