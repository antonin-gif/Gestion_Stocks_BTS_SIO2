using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Application_gestion_de_stocks
{
    public partial class ConsulterClients : Form
    {
        Connector connector;
        List<Client> clients;

        public ConsulterClients(Connector connector)
        {
            this.connector = connector;
            clients = new List<Client>();
            InitializeComponent();

        }

        private void ConsulterClients_Load(object sender, EventArgs e)
        {
            clients = connector.GetClients();
            listBox1.Items.AddRange(clients.ToArray());
        }
    }
}
