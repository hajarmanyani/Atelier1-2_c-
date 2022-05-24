using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Compteepargne : Compte
    {
        private double tauxint;
        public Compteepargne(Devise d, Client c, double ti) : base(d, c)
        {
            /*
            do{
                this.tauxint = Console.Read();
            }while( ti <0 && ti > 100)  
            */
            if (this.tauxint >= 0 && this.tauxint <= 100)
                this.tauxint = ti;
        }
        public override void afficher_compte()
        {
            base.afficher_compte();
            Console.WriteLine("Taux d'interet : " + this.tauxint);
        }

        public Devise InteretSolde(double taux)
        {
            Devise d = new Devise(taux / 100);
            return this.mt * d;

        }
        public override bool Retirer(Devise d)
        {
            return base.Retirer(d + this.InteretSolde(this.tauxint));
        }
    }
}
