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
    public partial class AjouterFournisseur : Form
    {
        private Connector connector;

        public AjouterFournisseur(Connector connector)
        {
            InitializeComponent();
            this.connector = connector;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomF = nomFournisseur.Text;
            string adresseF = adresseFournisseur.Text;
            string mail = emailFournisseur.Text;
            string telF = telFournisseur.Text;

            string query = "INSERT INTO FOURNISSEUR(nom, adresse, mail, telephone) VALUES('" + nomF + "','" +
                adresseF + "','" + mail + "','" + telF + "')";

            if(nomF.Length <= 3 || adresseF.Length <= 3 || mail.Length <= 3 || telF.Length != 10)
            {
                lbError.Visible = true;
            }
            else
            {
                connector.addFournisseur(nomF, adresseF, mail, telF);
                lbError.Text = "Fournisseur ajouté";
                lbError.ForeColor = System.Drawing.Color.Green;
                lbError.Visible = true;

                nomFournisseur.Text = "";
                adresseFournisseur.Text = "";
                emailFournisseur.Text = "";
                telFournisseur.Text = "";
            }            
        }

        private void lbError_Click(object sender, EventArgs e)
        {

        }
    }
}
