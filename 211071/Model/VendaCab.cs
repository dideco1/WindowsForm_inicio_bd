using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211071.Model
{
    internal class VendaCab
    {
        public int id {get;set;}
        public int idCliente {get;set;}
        public DateTime data { get; set; }
        public double total { get; set; }

        public int incluir ()
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySqlCommand("INSERT INTO vendaCab (idCliente, data, total) VALUES (@idCliente, @data, @total)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@idCliente", idCliente);
                Banco.comando.Parameters.AddWithValue("@data", data);
                Banco.comando.Parameters.AddWithValue("@total", total);
                Banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (int)Banco.comando.LastInsertedId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
