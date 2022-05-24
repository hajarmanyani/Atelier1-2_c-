using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class CompteCourant:Compte
    {
        private Devise Decouvert;
        public CompteCourant() { }
        public CompteCourant(Devise d, Client c,Devise dec):base(d,c)
        {
            this.Decouvert = dec;
        }
        public override bool Retirer(Devise d)
        {
            if (this.mt - d >= this.Decouvert)
            {
                return base.Retirer(d);
            }
            return false;
        }
    }
}
