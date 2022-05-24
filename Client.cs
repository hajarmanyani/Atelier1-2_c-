using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Client
    {
        private int mat;
        private static int cpt = 0;
        private string nom;
        private string prenom;
        private string adresse;
        private List<Compte> LC;
        public Client() { }
        public Client(string n, string p, string a)
        {
            cpt++;
            this.mat = cpt;
            this.nom = n;
            this.prenom = p;
            this.adresse = a;
            this.LC = new List<Compte>();
        }
        public void Afficher() {
            Console.WriteLine(this.nom + " " + this.prenom + " " + this.adresse);          
        }
        public void supprimer(Compte cp)
        {
            foreach (Compte C in LC)
            {
                if (C == cp)
                {
                    LC.Remove(cp);
                }
            }
        }

    }
}
