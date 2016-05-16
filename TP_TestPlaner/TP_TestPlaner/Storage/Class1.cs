using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml;

namespace TP_TestPlaner.Storage
{
    public class builder
    {
        SqlConnection sqlConnection1 = new SqlConnection("Data Source = DESKTOP-GJJRQEE\\SQLEXPRESS; Initial Catalog = DB_TestPlaner; "
               + "Integrated Security=SSPI;");
        SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;

        private void creader()
        {
            if ((reader != null) && (!reader.IsClosed))
            {
                reader.Close();
            }

        }


        public void connect()
        {

            sqlConnection1.Open();


        }

        public void diconnect()
        {
            sqlConnection1.Close();
        }

        public void Lade_Tester()
        {
            //umbauen
            creader();
            cmd.CommandText = "SELECT * FROM T_Prio";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;
            reader = cmd.ExecuteReader();

        }

        public void Lade_Personen()
        {
            //umbauen
            creader();
            cmd.CommandText = "SELECT * FROM T_Prio";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;
            reader = cmd.ExecuteReader();
        }

        public void Lade_Testauftraege()
        {
            //umbauen
            creader();
            cmd.CommandText = "SELECT * FROM T_Personen";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;
            reader = cmd.ExecuteReader();

        }
    }

}
