using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoIntegrador
{
    internal class Conexao
    {
        MySqlConnection Con = new MySqlConnection();
        private string data_source;

        public Conexao()
        {
            Con.ConnectionString = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
            // Criar Conex
        }

        public MySqlConnection Conectar()
        {
           if(Con.State == System.Data.ConnectionState.Closed)
            {
                Con.Open();
            }
            return Con;
        }
        public void Desconectar()
        {
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }
        }
    }
}
