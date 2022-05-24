using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class ComptePayant :Compte
    {
        private static double taux=50;
        public ComptePayant() { }
        public ComptePayant(Devise d, Client c,int t) :base(d,c) {
            taux = t;
        }
        public override bool Retirer(Devise d)
        {
            Devise com = new Devise();
            com = this.mt * (taux / 100);
            return base.Retirer(this.mt - com);
        }
        public override void deposer(Devise d)
        {
            Devise com = new Devise();
            com = this.mt * (taux / 100);
            this.mt = this.mt + d + com;
        }
    }
}
