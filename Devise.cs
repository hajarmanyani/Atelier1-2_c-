using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Devise
    {
        private double mont;
        private static int cpt = 0;
        private int mat;
        public Devise()
        {
            cpt++;
            this.mat = cpt;
        }
        public Devise(double m)
        {
            this.mont = m;
            cpt++;
            this.mat = cpt;
        }
        public Devise Add(Devise x1, Devise x2)
        {
            Devise dev = new Devise();
            dev.mont = x1.mont + x2.mont;
            return dev;
        }
        static public Devise operator+(Devise x1,Devise x2)
        {
            Devise dev = new Devise(x1.mont+x2.mont);
            return dev;
        }
        public bool Operatorinf(Devise x)
        {
            return (this.mont <= x.mont);
        }
        static public Devise operator-(Devise x1, Devise x2)
        {

            x1.mont -= x2.mont;
            return x1;
        }
        static public bool operator <=(Devise x1, Devise x2)
        {

            if (x1.mont <= x2.mont) { return true; }
            else { return false; }
        }
        static public bool operator>=(Devise x1, Devise x2)
        {

            if (x1.mont >= x2.mont) { return true; }
            else { return false;}
        }
        public void aficher()
        {
            Console.WriteLine(this.mat + " " + this.mont);
        }
        static public Devise operator /(Devise x1, Devise x2)
        {
            Devise dev = new Devise();
            dev.mont = x1.mont / x2.mont;
            return dev;
        }
        public bool Operatorsup(Devise x)
        {
            return (this.mont >= x.mont);
        }
        static public Devise operator *(Devise x1, Devise x2)
        {
            Devise dev = new Devise();
            dev.mont = x1.mont * x2.mont;
            return dev;
        }
        static public Devise operator *(Devise x1, double x)
        {
            Devise dev = new Devise();
            dev.mont = x1.mont * x;
            return dev;
        }
    }
}
