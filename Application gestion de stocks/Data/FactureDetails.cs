using System;
using System.Collections.Generic;
using System.Text;

namespace Application_gestion_de_stocks
{
    public class FactureDetails
    {
        protected int qtiteProduitsVendus;
        protected int prix;

        public FactureDetails(int q, int p)
        {
            this.qtiteProduitsVendus = q;
            this.prix = p;
        }

        //getters

        public int getQtitePV()
        {
            return this.qtiteProduitsVendus;
        }

        public int getPrix()
        {
            return this.prix;
        }

        //setters
        public void setQtitePV(int q)
        {
            this.qtiteProduitsVendus = q;
        }

        public void setPrix(int p)
        {
            this.prix = p;
        }

    }
}
