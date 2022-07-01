using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{
    class LiczbyZespolone
    {
        //część rzeczywista liczby zespolonej
        public double Re { get; set; }
        //część urojona liczby zespolonej
        public double Im { get; set; }
        //sprawdzenie czy liczba w mianowniku nie jest zerem
        public bool LiczbaZero => Re == 0 && Im == 0;
        //deklaracja konstruktora bezparametrowego
        //deklaracja konstruktora dwuargumentowego struktury LiczbyZespolone
        public LiczbyZespolone()
        {

        }
        public LiczbyZespolone(double re, double im)
        {
            Re = re; 
            Im = im;
        }                

        //przeciążenie operatorów jednoargumentowych
        public static LiczbyZespolone operator +(LiczbyZespolone z)
        {
            return z;
        }
        public static LiczbyZespolone operator +(LiczbyZespolone z1, LiczbyZespolone z2)
        {
            return new LiczbyZespolone(z1.Re + z2.Re, z1.Im + z2.Im);
        }
        public static LiczbyZespolone operator -(LiczbyZespolone z)
        {
            return new LiczbyZespolone(-z.Re, -z.Im);
        }
        public static LiczbyZespolone operator ~(LiczbyZespolone z)
        {
            return new LiczbyZespolone(z.Re, -z.Im);
        }
        public static LiczbyZespolone operator -(LiczbyZespolone z1, LiczbyZespolone z2)
        {
            return new LiczbyZespolone(z1.Re - z2.Re, z1.Im - z2.Im);
        }
        public static LiczbyZespolone operator *(LiczbyZespolone z1, LiczbyZespolone z2)
        {
            return new LiczbyZespolone((z1.Re * z2.Re) - (z1.Im * z2.Im), (z1.Re * z2.Im) + (z2.Re * z1.Im));
        }
        public static LiczbyZespolone operator /(LiczbyZespolone z1, LiczbyZespolone z2)
        {
            if (z2.LiczbaZero)
                throw new DivideByZeroException();
            return new LiczbyZespolone((Math.Round(((z1.Re * z2.Re) + (z1.Im * z2.Im)) / (Math.Pow(z2.Re, 2) + Math.Pow(z2.Im, 2)), 2)), Math.Round(((z2.Re * z1.Im) - (z1.Re * z2.Im)) / (Math.Pow(z2.Re, 2) + Math.Pow(z2.Im, 2)), 2));
        }
        public static implicit operator LiczbyZespolone(double L)
        {
            return new LiczbyZespolone(L, 0.0);
        }        
        public override string ToString()
        {
            if (LiczbaZero)
                return "0";
            string wartosc = "";
            if (Re != 0)
            {
                wartosc += Re.ToString();
                if (Im > 0)
                    wartosc += " + ";
                else if (Im < 0)
                    wartosc += " - ";
            }
            if (Im != 0)
                wartosc += Math.Abs(Im).ToString() + "i";
            return wartosc;
        }
    }
}
