using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Application_gestion_de_stocks
{
    public partial class AjouterProduit : Form
    {

        private Connector connector;
        public AjouterProduit(Connector connector)
        {
            InitializeComponent();
            this.connector = connector;
        }

        private void btnAjoutCli_Click(object sender, EventArgs e)
        {
            string nomP = tbNomPdt.Text;
            int poidsP = Int32.Parse(txtPoidsPdt.Text) * 1000;
            int prixVP = Int32.Parse(prixProd.Text) * 100;
            char allee = Convert.ToChar(alleeProd.Text);
            int place = Int32.Parse(placeProd.Text);
            int etage = Int32.Parse(etageProd.Text);

            List<EmplacementStock> emplacements = connector.getEmplacements();

            bool trouve = false;
            EmplacementStock emplct = null;
            foreach (EmplacementStock emplacement in emplacements)
            {
                if (emplacement.getAllee() == allee
                    && emplacement.getEtage() == etage
                    && emplacement.getPLace() == place)
                {
                    trouve = true;
                    emplct = emplacement;
                    break;
                }
            }
            int id = 0;
            if (trouve == false)
            {
                id = connector.addEmplacement(allee, place, etage);
            }
            else
            {
                id = emplct.id;
            }
            connector.addProduct(id, nomP, poidsP, prixVP);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
