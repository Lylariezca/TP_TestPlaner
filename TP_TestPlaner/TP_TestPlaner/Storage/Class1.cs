using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace TP_TestPlaner.Storage
{
    class FirebirdStorage : IStorage
    {
        private string connString = "User=SYSDBA;" +
                                    "Password=masterkey;" +
                                    "Database=C:\\Users\\neuge\\Documents\\GitHub\\DB_TestPlaner.FDB;" + //Datenbankpfad muss angepasst werden
                                    "DataSource=localhost;" +
                                    "Port=3050;";
        private FbConnection conn;

        public FirebirdStorage(string connString)
        {
            this.connString = connString;
            CreateTablesIfNeeded();
        }

        public FirebirdStorage()
        {
            CreateTablesIfNeeded();
        }

        ~FirebirdStorage()
        {
            conn.Close();
        }

        private void CreateTablesIfNeeded()
        {
            conn = new FbConnection(connString);
            conn.Open();

            {//Tester
                if (!CheckDatabaseObjectExists("TESTER", "table"))
                {
                    string sql = "CREATE TABLE TESTER" +
                                "(" +
                                "P_KUERZEL NVARCHAR(10) RIMARY KEY," +
                                "NACHNAME NVARCHAR(50)," +
                                "VORNAME NVARCHAR(50)" +
                                ")";
                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                //Projekte
                if (!CheckDatabaseObjectExists("PROJEKTE", "table"))
                {
                    string sql = "CREATE TABLE PROJEKTE" +
                        "(" +
                        "P_ID INT PRIMARY KEY," +
                        "BEZEICHNUNG NVARCHAR(50)" +
                        ")";
                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                if (!CheckDatabaseObjectExists("GEN_PROJEKTE_ID", "generator"))
                {
                    string sql = "CREATE GENERATOR GEN_PROJEKTE_ID;";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                if (!CheckDatabaseObjectExists("TRIG_PROJEKTE_ID","trigger"))
                {
                    string sql = "CREATE TRIGGER TRIG_PROJEKTE_ID FOR PROJEKTE " +
                        "ACTIVE BEFORE INSERT POSITION 0 " +
                        "AS" +
                        "BEGIN" +
                        "if (NEW.P_ID is NULL) then NEW.P_ID = GEN_ID(GEN_PROJEKTE_ID, 1);" +
                        "END";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                //Arten
                if (!CheckDatabaseObjectExists("ARTEN", "table"))
                {
                    string sql = "CREATE TABLE ARTEN" +
                        "(" +
                        "P_ID INT PRIMARY KEY," +
                        "BEZEICHNUNG NVARCHAR(20)" +
                        ")";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                if (!CheckDatabaseObjectExists("GEN_ARTEN_ID", "generator"))
                {
                    string sql = "CREATE GENERATOR GEN_ARTEN_ID;";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                if (!CheckDatabaseObjectExists("TRIG_ARTEN_ID", "trigger"))
                {
                    string sql = "CREATE TRIGGER TRIG_ARTEN_ID FOR ARTEN " +
                        "ACTIVE BEFORE INSERT POSITION 0 " +
                        "AS" +
                        "BEGIN" +
                        "if (NEW.P_ID is NULL) then NEW.P_ID = GEN_ID(GEN_ARTEN_ID, 1);" +
                        "END";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                //Status
                if (!CheckDatabaseObjectExists("STATUS", "table"))
                {
                    string sql = "CREATE TABLE STATUS" +
                        "(" +
                        "P_ID INT PRIMARY KEY" +
                        "BEZEICHNUNG NVARCHAR(20)" +
                        ")";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                if (!CheckDatabaseObjectExists("GEN_STATUS_ID", "generator"))
                {
                    string sql = "CREATE GENERATOR GEN_STATUS_ID;";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                if (!CheckDatabaseObjectExists("TRIG_STATUS_ID", "trigger"))
                {
                    string sql = "CREATE TRIGGER TRIG_STATUS_ID FOR STATUS " +
                        "ACTIVE BEFORE INSERT POSITION 0 " +
                        "AS" +
                        "BEGIN" +
                        "if (NEW.P_ID is NULL) then NEW.P_ID = GEN_ID(GEN_STATUS_ID, 1);" +
                        "END";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                //Prioritaeten
                if (!CheckDatabaseObjectExists("PRIO", "table"))
                {
                    string sql = "CREATE TABLE PRIO" +
                        "(" +
                        "P_ID INT PRIMARY KEY," +
                        "BEZEICHNUNG NVARCHAR(20)" +
                        ")";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                if (!CheckDatabaseObjectExists("GEN_PRIO_ID", "generator"))
                {
                    string sql = "CREATE GENERATOR GEN_PRIO_ID;";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                if (!CheckDatabaseObjectExists("TRIG_PRIO_ID", "trigger"))
                {
                    string sql = "CREATE TRIGGER TRIG_PRIO_ID FOR PRIO " +
                        "ACTIVE BEFORE INSERT POSITION 0 " +
                        "AS" +
                        "BEGIN" +
                        "if (NEW.P_ID is NULL) then NEW.P_ID = GEN_ID(GEN_PRIO_ID, 1);" +
                        "END";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                //Risiken
                if (!CheckDatabaseObjectExists("RISIKEN", "table"))
                {
                    string sql = "CREATE TABLE RISIKEN" +
                        "(" +
                        "P_ID INT PRIMARY KEY," +
                        "BEZEICHNUNG NVARCHAR(20)" +
                        ")";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                if (!CheckDatabaseObjectExists("GEN_RISIKEN_ID", "generator"))
                {
                    string sql = "CREATE GENERATOR GEN_RISIKEN_ID;";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                if (!CheckDatabaseObjectExists("TRIG_RISIKEN_ID", "trigger"))
                {
                    string sql = "CREATE TRIGGER TRIG_RISIKEN_ID FOR RISIKEN " +
                        "ACTIVE BEFORE INSERT POSITION 0 " +
                        "AS" +
                        "BEGIN" +
                        "if (NEW.P_ID is NULL) then NEW.P_ID = GEN_ID(GEN_RISIKEN_ID, 1);" +
                        "END";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                //Teatauftraege
                if (!CheckDatabaseObjectExists("TESTAUFTRAEGE", "table"))
                {
                    string sql = "CREATE TABLE TESTAUFTRAEGE" +
                        "(" +
                        "P_ID INT PRIMARY KEY," +
                        "TITEL NVARCHAR(50) NOT NULL," +
                        "PRIORITAET INT FOREIGN KEY REFERENCES PRIO (P_ID)," +
                        "PROJEKT INT FOREIGN KEY REFERENCES PROJEKTE (P_PROJEKT_ID)," +
                        "PROJEKTVERSION NVARCHAR(10)," +
                        "TESTER NVARCHAR(0) FOREIGN KEY REFERENCES TESTER (P_KUERZEL)" +
                        "ART INT FOREIGN KEY REFERENCES ARTEN (P_ID)," +
                        "STARTDATUM DATE," +
                        "ENDDATUM DATE," +
                        "TERMIN DATE NOT NULL," +
                        "STATUS INT FOREIGN KEY REFERENCES STATUS (P_ID)" +
                        "RISIKO INT FOREIGN KEY REFERENCES RISIKEN (P_ID)" +
                        "TAERSTELLER NVARCHAR(50)" +
                        ")";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                if (!CheckDatabaseObjectExists("GEN_TESTAUFTRAEGE_ID", "generator"))
                {
                    string sql = "CREATE GENERATOR GEN_TESTAUFTRAEGE_ID;";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                if (!CheckDatabaseObjectExists("TRIG_TESTAUFTRAEGE_ID", "trigger"))
                {
                    string sql = "CREATE TRIGGER TRIG_TESTAUFTRAEGE_ID FOR TESTAUFTRAEGE " +
                        "ACTIVE BEFORE INSERT POSITION 0 " +
                        "AS" +
                        "BEGIN" +
                        "if (NEW.P_ID is NULL) then NEW.P_ID = GEN_ID(GEN_TESTAUFTRAEGE_ID, 1);" +
                        "END";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

            }
        }
        private bool CheckDatabaseObjectExists(string objectName, string type)
        {
            string sql = "";
            switch (type)
            {
                case "table":
                    sql = "SELECT RDB$RELATION_NAME FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG=0 AND RDB$RELATION_NAME = '" +
                        objectName + "'";
                    break;
                case "generator":
                    sql = "SELECT RDB$GENERATOR_NAME FROM RDB$GENERATORS WHERE RDB$SYSTEM_FLAG=0 AND RDB$GENERATOR_NAME='" +
                        objectName + "'";
                    break;
                case "trigger":
                    sql = "SELECT RDB$TRIGGER_NAME FROM RDB$TRIGGERS WHERE RDB$SYSTEM_FLAG=0 AND RDB$TRIGGER_NAME='" +
                        objectName + "'";
                    break;
            }
            FbCommand com = new FbCommand(sql, conn);
            FbDataReader dr = com.ExecuteReader();
            bool exists = false;
            if (dr.Read())
            {
                exists = true;
            }
            dr.Close();
            return exists;
        }  

    }

}
