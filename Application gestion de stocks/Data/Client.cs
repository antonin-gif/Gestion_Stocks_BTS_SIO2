using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Application_gestion_de_stocks
{
    public class Client
    {
        public int Id { get; private set; }
        protected string nom;
        protected string prenom;
        protected string telephone;

        //atributes association
        protected List<Facture> mesFactures;

        public Client(int id,string n, string p, string t)
        {
            this.Id = id;
            this.nom = n;
            this.prenom = p;
            this.telephone = t;
            this.mesFactures = new List<Facture>();
        }

        //getters
        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public string getTelephone()
        {
            return this.telephone;
        }

        public List<Facture> getMesFactures()
        {
            return this.mesFactures;
        }

        //setters
        public void setNom(string n)
        {
            this.nom = n;
        }

        public void setPrenom(string p)
        {
            this.prenom = p;
        }

        public void setTelephone(string t)
        {
            this.telephone = t;
        }


        public override string ToString()
        {
            return $"{Id} {nom} {prenom} {telephone}";
        }

       
    }
}
