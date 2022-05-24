using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Operation
    {
         private readonly int cpt = 0;
         int mat;
        string libelle;
        DateTime dateop;
        Devise mop;
        public Operation() { }
        public Operation(string l, Devise mop)
        {
            cpt++;
            this.mat = cpt;
            this.mop = mop;
            this.libelle = l;
            this.dateop = new DateTime();
        }
        public override string ToString()
        {
            string s=this.dateop.ToString()+"|"+this.libelle + "|" +this.mop;
            return s;
        }
    }
}
