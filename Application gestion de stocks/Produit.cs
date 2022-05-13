using System;
using System.Collections.Generic;
using System.Text;

namespace Application_gestion_de_stocks
{
    public class Produit
    {
        protected string nom;
        protected int poids;
        protected int prixVente;

        //attributes association
        protected EmplacementStock emplacement;
        protected List<FactureDetails> detailsFactures;
        protected List<CommandeDetails> detailsCommande;

        public Produit(string n, int p, int pr, EmplacementStock es)
        {
            this.nom = n;
            this.prixVente = pr;
            this.emplacement = es;
            this.detailsFactures = new List<FactureDetails>();
            this.detailsCommande = new List<CommandeDetails>();
        }

        //les getters
        public string getNom()
        {
            return this.nom;
        }

        public int getPoids()
        {
            return this.poids;
        }

        public int getPrixVente()
        {
            return this.prixVente;
        }

        public EmplacementStock getEmplacement()
        {
            return this.emplacement;
        }

        public List<FactureDetails> GetFactureDetails()
        {
            return this.detailsFactures;
        }

        public List<CommandeDetails> GetCommandeDetails()
        {
            return this.detailsCommande;
        }

        //les setters

        public void setNom(string unNom)
        {
            this.nom = unNom;
        }

        public void setPoids(int p)
        {
            this.poids = p;
        }

        public void setPrixVente(int p)
        {
            this.prixVente = p;
        }
    }
}
