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
    }
}
