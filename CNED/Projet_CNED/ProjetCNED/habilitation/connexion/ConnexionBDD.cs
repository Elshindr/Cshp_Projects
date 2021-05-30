using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Habilitations.connexion
{
    public class ConnexionBDD
    {
        private static ConnexionBDD instance = null;

        private MySqlConnection connection;

        private MySqlCommand command;

        private MySqlDataReader reader;
        private ConnexionBDD(string chaineConnection)
        {
            try
            {
                this.connection = new MySqlConnection(chaineConnection);
                this.connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }

        public static ConnexionBDD GetInstance(string chaineConnection)
        {
            if(instance is null)
            {
                instance = new ConnexionBDD(chaineConnection);
            }

            return instance;
        }

        public void ReqUpdate(string req, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(req, connection);
                foreach (KeyValuePair<string, object> unparameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(unparameter.Key, unparameter.Value));
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void ReqSelect(string req)
        {
            try
            {
                command = new MySqlCommand(req, connection);
                reader = command.ExecuteReader();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        public bool Read()
        {
            if (reader is null)
            {
                return false;
            }

            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        public object Field(string champ)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[champ];
            }
            catch
            {
                return null;
            }
        }

        public void Close()
        {
            if(!(reader is null))
            {
                reader.Close();
            }
        }
    }
}
