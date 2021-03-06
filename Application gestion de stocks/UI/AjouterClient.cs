using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Application_gestion_de_stocks
{
    public partial class AjouterClient : Form     
    {

        private Connector connector;
        public AjouterClient()
        {
            InitializeComponent();
            this.connector = connector;
        }

        private void emailFournisseur_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ajouterCli_Click(object sender, EventArgs e)
        {
            string nom = nomClient.Text;
            string prenom = prenomCli.Text;
            string tel = telClient.Text;
            
            if(nom.Length <= 3 || prenom.Length <= 3 || tel.Length <= 3)
            {
                lbError.Text = "Les champs doivent être composés d'au moins 4 caractères";
                lbError.Visible = true;
                lbError.ForeColor = System.Drawing.Color.Red;
            }
            else{
                string query = "INSERT INTO CLIENT(nom, prenom, telephone) VALUES ('" + nom + "', '" + prenom + "', '" + tel + "');";

                connector.addClient(nom, prenom ,tel);

                lbError.Text = "Client ajouté";
                lbError.Visible = true;
                lbError.ForeColor = System.Drawing.Color.Green;

                nomClient.Text = "";
                prenomCli.Text = "";
                telClient.Text ="";
            }
        }
    }
}
