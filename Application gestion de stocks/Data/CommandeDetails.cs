using System;
using System.Collections.Generic;
using System.Text;

namespace Application_gestion_de_stocks
{
    public class CommandeDetails
    {
        protected int qtiteProduitsAchetes;
        protected int prix;

        public CommandeDetails(int q, int p)
        {
            this.qtiteProduitsAchetes = q;
            this.prix = p;
        }

        //getters
        public int getQtiteProduitsAchetes()
        {
            return this.qtiteProduitsAchetes;
        }

        public int getPrix()
        {
            return this.prix;
        }

        //setters
        public void setQtiteProdAchetes(int q)
        {
            this.qtiteProduitsAchetes = q;
        }

        public void setPrix(int p)
        {
            this.prix = p;
        }
    }
}
