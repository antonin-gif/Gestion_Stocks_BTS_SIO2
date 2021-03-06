using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Application_gestion_de_stocks
{
    public class Connector
    {
        private MySqlConnection MySqlConnection;

        public Connector()
        {
            MySqlConnection = new MySqlConnection("database=appgestiondestocks; " +
                "server=127.0.0.1; user id=root; pwd=SQLanto21");
            MySqlConnection.Open();
        }

        public void Stop()
        {
            MySqlConnection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return MySqlConnection;
        }

        public void addProduct(int id_empla, string nom, int pds, int prix)
        {
            string query = $"INSERT INTO PRODUIT(id_emplacement, nom, poids, prixvente) VALUES ('{id_empla}', '{nom}', '{pds}', '{prix}')";
            Post(query);
        }

        public void addClient(string nom, string prenom, string tel)
        {
            string query = $"INSERT INTO PRODUIT(nom, prenom, telephone) VALUES ('{nom}', '{prenom}', '{tel}')";
            Post(query);
        }

        public int addEmplacement(char allee, int place, int etage)
        {
            string query = $"INSERT INTO EMPLACEMENT_STOCK(allee, place, etage) " +
                $"VALUES ('{allee}', '{place}', '{etage}')";
            Post(query);

            List<EmplacementStock> emplacements = getEmplacements();
            int id = emplacements[emplacements.Count - 1].id;

            return id;
        }

        public List<EmplacementStock> getEmplacements()
        {
            List<EmplacementStock> emplacements = new List<EmplacementStock>();

            string query = "SELECT * FROM EMPLACEMENT_STOCK;";

            MySqlCommand cmd = MySqlConnection.CreateCommand();
            cmd.CommandText = query;

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = int.Parse(reader[0].ToString());
                    char allee = Char.Parse(reader[1].ToString());
                    int place = int.Parse(reader[2].ToString());
                    int etage = int.Parse(reader[3].ToString());

                    EmplacementStock emplacementStock = new EmplacementStock(id, allee, place, etage);
                    emplacements.Add(emplacementStock);
                }
            }


            return emplacements;
        }


        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            string query = "SELECT * FROM USER;";

            MySqlCommand cmd = MySqlConnection.CreateCommand();
            cmd.CommandText = query;

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string mail = reader[3].ToString();
                    string password = reader[4].ToString();

                    User user = new User(mail, password);
                    users.Add(user);
                }
            }

            return users;
        }

        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();

            string query = "SELECT * FROM CLIENT ORDER BY (ID) DESC;";

            MySqlCommand cmd = MySqlConnection.CreateCommand();
            cmd.CommandText = query;

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = int.Parse(reader[0].ToString());
                    string nom = reader[1].ToString();
                    string prenom = reader[2].ToString();
                    string telephone = reader[3].ToString();

                    Client client = new Client(id, nom, prenom, telephone);
                    clients.Add(client);
                }
            }

            return clients;
        }


        private void Post(string query)
        {
            MySqlCommand cmd = MySqlConnection.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public void addFournisseur(string nom, string adresse, string mail, string tel)
        {
            string query = $"INSERT INTO FOURNISSEUR(nom, adresse, mail, telephone) VALUES ('{nom}', '{adresse}', '{mail}', '{tel}')";
            Post(query);
        }
    }


}
