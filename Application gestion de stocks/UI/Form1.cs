using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Application_gestion_de_stocks.Uitlity;

namespace Application_gestion_de_stocks
{
    public partial class FormMain : Form
    {
        Connector connector;
        
        public FormMain(Connector connector)
        {
            this.connector = connector;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjoutConsultation ac = new AjoutConsultation(connector);
            ac.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string loginAdm = emailAdmin.Text;
            string mdpAdm = mdpAdmin.Text;


            List<User> users = connector.GetUsers();

            foreach(User user in users)
            {
                string decryptedPassword = Encryptor.DecryptString(user.getMdp());

                if(decryptedPassword == mdpAdm)
                {
                    btnLancerApp.Visible = true;
                    lbError.Visible = false;
                    return;
                }
            }

            lbError.Visible = true;
            
        }
       
    }

}
