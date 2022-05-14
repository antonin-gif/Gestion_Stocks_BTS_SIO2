using System;
using System.Collections.Generic;
using System.Text;

namespace Application_gestion_de_stocks
{
    public class EmplacementStock
    {
        public int id { get; private set; }
        protected char allee;
        protected int place;
        protected int etage;

        //attributes association
        protected List<Produit> produitsDeLemplacement;

        public EmplacementStock(int id, char a, int p, int e)
        {
            this.id = id;
            this.allee = a;
            this.place = p;
            this.etage = e;
            this.produitsDeLemplacement = new List<Produit>();
        }

        //les getters
        public char getAllee()
        {
            return this.allee;
        }

        public int getPLace()
        {
            return this.place;
        }

        public int getEtage()
        {
            return this.etage;
        }

        public List<Produit> getProduitsEmplacement()
        {
            return this.produitsDeLemplacement;
        }

        //les setters
        public void setAllee(char uneAllee)
        {
            this.allee = uneAllee;
        }

        public void setPlace(int unePlace)
        {
            this.place = unePlace;
        }

        public void setEtage(int unEtage)
        {
            this.etage = unEtage;
        }
    }
}
