using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Application_gestion_de_stocks
{
    public partial class Ajouter : Form
    {
        private Connector connector;
        public Ajouter(Connector connector)
        {
            this.connector = connector;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AjouterFournisseur a = new AjouterFournisseur(connector);
            a.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AjouterClient a = new AjouterClient();
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterCommande a = new AjouterCommande();
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjouterFactureClient a = new AjouterFactureClient();
            a.Show();
            this.Close();
        }

        private void btn_AjouterProduit_Click(object sender, EventArgs e)
        {
            AjouterProduit a = new AjouterProduit(connector);
            a.Show();
            this.Close();
        }
    }
}
