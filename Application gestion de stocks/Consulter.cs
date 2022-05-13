using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Application_gestion_de_stocks
{
    public partial class Consulter : Form
    {
        public Consulter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsulterFournisseurs c = new ConsulterFournisseurs();
            c.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsulterCommandes c = new ConsulterCommandes();
            c.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsulterProduits c = new ConsulterProduits();
            c.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsulterFacturesClient c = new ConsulterFacturesClient();
            c.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsulterClients c = new ConsulterClients();
            c.Show();
            this.Close();
        }
    }
}
