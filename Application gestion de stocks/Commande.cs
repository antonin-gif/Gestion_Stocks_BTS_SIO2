using System;
using System.Collections.Generic;
using System.Text;

namespace Application_gestion_de_stocks
{
    class Commande
    {
        protected DateTime dateLivraisonCommande;
        protected DateTime dateCommande;
        protected int prixCommande;
        protected bool livraisonCommandeEffectuee;

        //attributes association
        protected Fournisseur monFournisseur;
        protected List<CommandeDetails> detailsFacture;

        public Commande(DateTime dtc, DateTime dc, int p, bool lce, Fournisseur f)
        {
            this.dateLivraisonCommande = dtc;
            this.dateCommande = dc;
            this.prixCommande = p;
            this.livraisonCommandeEffectuee = lce;
            this.monFournisseur = f;
            this.detailsFacture = new List<CommandeDetails>();
        }

        //getters
        public DateTime getDateLivraisonCommande()
        {
            return this.dateLivraisonCommande;
        }
        public DateTime getDateCommande()
        {
            return this.dateCommande;
        }
        public int getPrixCommande()
        {
            return this.prixCommande;
        }

        public bool getLivraisonCommandeEffectuee()
        {
            return this.livraisonCommandeEffectuee;
        }
        public Fournisseur getMonFournisseur()
        {
            return this.monFournisseur;
        }

        //setters
        public void setDateLivraisonCommande(DateTime dlc)
        {
            this.dateLivraisonCommande = dlc;
        }

        public void setDateCommande(DateTime dc)
        {
            this.dateCommande = dc;
        }

        public void setPrixCommande(int pc)
        {
            this.prixCommande = pc;
        }
        public void setLivraisonCommandeEffectuee(bool lce)
        {
            this.livraisonCommandeEffectuee = lce;
        }

    }
}
