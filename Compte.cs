using System;
using System.Collections.Generic;
using System.Text;


namespace App1
{
    class Compte
    {
        static int cpt;
        private int mat;
        protected Devise mt;
        private Client c;
        private List<Operation> opr;
        public Compte()
        {
            this.mt = new Devise(); ;
            this.c = new Client();
            this.opr = new List<Operation>();
        }
        public Compte(Devise d, Client c)
        {
            this.mt = d;
            this.c = c;
        }
        virtual public bool Retirer(Devise d)
        {
            if (d.Operatorinf(this.mt)) { 
                this.mt = this.mt - d; 
                Operation op=new Operation ("-",d);
                return true; 
            }
            else { return false; }
        }
        virtual public void deposer(Devise d)
        {
            this.mt = this.mt.Add(d, this.mt);
            Operation op = new Operation("+", d);
            this.opr.Add(op);
        }
        virtual public bool transferer(Compte C, Devise dev)
        {
            if (this.Retirer(dev) == true)
            {
                C.deposer(dev);
                return true;
            }
            return false;
        }
        public virtual void afficher_compte()
        {
            c.Afficher();
            mt.aficher();
            Console.WriteLine(this.mat + " " + this.mt);
        }
        static public bool operator ==(Compte cp, Compte cp2)
        {
            if (cp.mat == cp2.mat)
            {
                return true;
            }
            else { return false; }
        }
        static public bool operator !=(Compte cp, Compte cp2)
        {
            return !(cp == cp2);
        }

    }
}
