using System;
using System.Collections.Generic;
using System.Text;

namespace Application_gestion_de_stocks
{
    class User
    {
        protected string prenom;
        protected string nom;
        protected string mail;
        protected string mdp;

        public User(string p, string n, string m, string mdp)
        {
            this.prenom = p;
            this.nom = n;
            this.mail = m;
            this.mdp = mdp;
        }

        //getters
        public string getPrenom()
        {
            return this.prenom;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getMail()
        {
            return this.mail;
        }

        public string getMdp()
        {
            return this.mdp;
        }

        //setters

        public void setPrenom(string p)
        {
            this.prenom = p;
        }

        public void setNom(string n)
        {
            this.prenom = n;
        }

        public void setMail(string m)
        {
            this.prenom = m;
        }

        public void setMdp(string mdp)
        {
            this.prenom = mdp;
        }

    }
}
