using System;
using System.Collections.Generic;
using System.Text;

namespace Application_gestion_de_stocks
{
    public class Facture
    {
        protected string adresse;
        protected DateTime dateLivraisonFacture;
        protected DateTime dateFacture;
        protected bool livraisonEffectuee;
        protected int prixFacture;

        //attributes association
        protected Client leClient;
        protected List<FactureDetails> detailsFactures;

        public Facture(string a, DateTime d, DateTime df, bool l, int p, Client c)
        {
            this.adresse = a;
            this.dateLivraisonFacture = d;
            this.dateFacture = df;
            this.livraisonEffectuee = l;
            this.prixFacture = p;
            this.leClient = c;
            this.detailsFactures = new List<FactureDetails>();
        }

        //getters
        public string getAdresse()
        {
            return this.adresse;
        }

        public DateTime getDateLivraisonFacture()
        {
            return this.dateLivraisonFacture;
        }

        public DateTime getDateFacture()
        {
            return this.dateFacture;
        }

        public bool getLivraisonEffectuee()
        {
            return this.livraisonEffectuee;
        }

        public int getPrixFacture()
        {
            return this.prixFacture;
        }

        public Client getClient()
        {
            return this.leClient;
        }

        public List<FactureDetails> GetFactureDetails()
        {
            return this.detailsFactures;
        }

        //setters
        public void setAdresse(string a)
        {
            this.adresse = a;
        }

        public void setDateLivraisonFacture(DateTime d)
        {
            this.dateLivraisonFacture = d;
        }

        public void setDateFacture(DateTime d)
        {
            this.dateLivraisonFacture = d;
        }


        public void setLivraisonEffectuee(bool l)
        {
            this.livraisonEffectuee = l;
        }

        public void setPrixFacture(int p)
        {
            this.prixFacture = p;
        }
    }
}
