using System;
using System.Collections.Generic;
using System.Text;

namespace Application_gestion_de_stocks
{
    class Fournisseur
    {
        protected string nom;
        protected string adresse;
        protected string mail;
        protected string telephone;

        //attributes association
        protected List<Commande> mesCommandes;

        public Fournisseur(string n, string a, string m, string t)
        {
            this.nom = n;
            this.adresse = a;
            this.mail = m;
            this.telephone = t;
            this.mesCommandes = new List<Commande>();
        }

        //getters
        public string getNom()
        {
            return this.nom;
        }

        public string getAdresse()
        {
            return this.adresse;
        }

        public string getMail()
        {
            return this.mail;
        }

        public string getTelephone()
        {
            return this.telephone;
        }

        public List<Commande> getMesCommandes()
        {
            return this.mesCommandes;
        }

        //setters

        public void setNom(string n)
        {
            this.nom = n;
        }

        public void setAdresse(string a)
        {
            this.adresse = a;
        }

        public void setMail(string m)
        {
            this.mail = m;
        }

        public void setTelephone(string t)
        {
            this.telephone = t;
        }
    }
}
