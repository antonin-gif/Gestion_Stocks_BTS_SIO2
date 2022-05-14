using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Application_gestion_de_stocks
{
    public partial class AjoutConsultation : Form
    {
        private Connector connector;
        public AjoutConsultation(Connector connector)
        {
            this.connector = connector;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter a = new Ajouter(connector);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consulter c = new Consulter(connector);
            c.Show();
        }
    }
}
