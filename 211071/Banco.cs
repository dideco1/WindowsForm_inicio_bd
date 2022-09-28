using System;
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
    }
}
