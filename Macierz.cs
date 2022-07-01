using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//dodanie nowej przestrzeni nazw dla udostępnienia klas opisujących kontrolki formularza
using System.Windows.Forms;

namespace Projekt2
{
    class Macierz
    {
        //deklaracje wewnętrzne (lokalne) klasy
        private float[,] macierz;
        //deklaracja konstrunktora klasy macierz
        public Macierz(ushort LiczbaWierszy, ushort LiczbaKolumn)
        {
            macierz = new float[LiczbaWierszy, LiczbaKolumn];
        }
        //deklaracja właściwości
        public ushort LiczbaWierszy
        {
            get { return (ushort)macierz.GetLength(0); }
        }

        public ushort LiczbaKolumn
        {
            get { return (ushort)macierz.GetLength(1); }
        }

        //A[i, j]
        //deklaracja indeksator macierzy, który będzie umożliwiał dostęp do macierzy w notacji matematycznej A[i, j] = 3.45F

        public float this[ushort NrWiersza, ushort NrKolumny]
        {
            set 
            {
                //sprawdzenie poprawności  indeksów dostępu do Macierzy
                if ((NrWiersza >= 0) && (NrWiersza < macierz.GetLength(0)) && (NrKolumny >= 0) && (NrKolumny < macierz.GetLength(1)))
                    macierz[NrWiersza, NrKolumny] = value;
                else
                    //sygnalizujemy błąd przez mechanizm wyrzucania wyjątku
                    throw new IndexOutOfRangeException("ERROR: wartość jednego lub obydwu z indeksów macierzy wykracza poza dozwolony zakres");
            }
            get 
            {
                //sprawdzenie poprawności indeksów dostępu do Macierzy
                if ((NrWiersza >= 0) && (NrWiersza < macierz.GetLength(0)) && (NrKolumny >= 0) && (NrKolumny < macierz.GetLength(1)))
                    //indeksy są poprawne i możemy zrealizować zapis
                    return macierz[NrWiersza, NrKolumny];
                else
                    //sygnalizujemy błąd przez mechanizm wyrzucania wyjątku
                    throw new IndexOutOfRangeException("ERROR: wartość jednego lub obydwu z indeksów macierzy wykracza poza dozwolony zakres");
            }
        }

        //deklaracje metod i przeciążeń operatorów arytmetycznych
        //przeciążenie operatora "+"
        public static Macierz operator +(Macierz a, Macierz b)
        {//sprawdzenie warunku wejściowego
            if (a.LiczbaWierszy != b.LiczbaWierszy || a.LiczbaKolumn != b.LiczbaKolumn)
            {//sygnalizacja błędu przez tzw. "wyrzucenie" wyjątku
                throw new ArgumentException("ERROR: wymiary macierzy nie spełniają warunku zgodności");
            }

            //rozmiary macierzy a ib są zgodne
            //deklaracja pomocnicza macierzy C dla przechowania wyniku obliczeń
            Macierz C = new Macierz(a.LiczbaWierszy, a.LiczbaKolumn);
            //sumowanie elementów macierzy a i b
            for (ushort i = 0; i < a.LiczbaWierszy; i++)
            {
                for (ushort j = 0; j < a.LiczbaKolumn; j++)
                {
                    C.macierz[i, j] = a.macierz[i, j] + b.macierz[i, j];
                }
            }
            //zwrócenie wyniku obliczeń 
            return C;
        }

        //przeciążenie operatora "-"
        public static Macierz operator -(Macierz a, Macierz b)
        {//sprawdzenie warunku wejściowego
            if (a.LiczbaWierszy != b.LiczbaWierszy || a.LiczbaKolumn != b.LiczbaKolumn)
            {//sygnalizacja błędu przez tzw. "wyrzucenie" wyjątku
                throw new ArgumentException("ERROR: wymiary macierzy nie spełniają warunku zgodności");
            }

            //rozmiary macierzy a i b są zgodne
            //deklaracja pomocnicza macierzy C dla przechowania wyniku obliczeń
            Macierz C = new Macierz(a.LiczbaWierszy, a.LiczbaKolumn);
            //sumowanie elementów macierzy a i b
            for (ushort i = 0; i < a.LiczbaWierszy; i++)
            {
                for (ushort j = 0; j < a.LiczbaKolumn; j++)
                {
                    C.macierz[i, j] = a.macierz[i, j] - b.macierz[i, j];
                }
            }
            //zwrócenie wyniku obliczeń 
            return C;
        }

        //przeciążenie operatora "*"
        public static Macierz operator *(Macierz a, Macierz b)
        {//sprawdzenie warunku wykonalności mnożenia macierzy
            if (a.LiczbaWierszy != b.LiczbaWierszy || a.LiczbaKolumn != b.LiczbaKolumn)
                //wyrzucamy wyjątek dla sygnalizacji błędu
                throw new ArgumentException("ERROR: niezgodność rozmiarów macierzy");
            Macierz C = new Macierz(a.LiczbaWierszy, b.LiczbaKolumn);
            //wykonanie mnożenia
            for (ushort i = 0; i < a.LiczbaWierszy; i++)
            {
                for (ushort j = 0; j < b.LiczbaKolumn; j++)
                {
                    C.macierz[i, j] = 0.0F;
                    //obliczenie sumy iloczynów
                    for (ushort k = 0; k < b.LiczbaWierszy; k++)
                    {
                        C.macierz[i, j] += a.macierz[i, k] * b.macierz[k, j];
                    }
                }
            }
            //zwrotne przekazanie wyniku
            return C;
        }

        public static Macierz operator *(float Liczba, Macierz a)
        {
            Macierz C = new Macierz(a.LiczbaWierszy, a.LiczbaKolumn);
            for (ushort i = 0; i < a.LiczbaWierszy; i++)
            {
                for (ushort j = 0; j < a.LiczbaKolumn; j++)
                {
                    C.macierz[i, j] = Liczba * a.macierz[i, j];
                }
            }
            return C;
        }

        public static bool operator ==(Macierz a, Macierz b)
        {
            if (a.LiczbaWierszy == b.LiczbaWierszy && a.LiczbaKolumn == b.LiczbaKolumn)
            {
                for (ushort i = 0; i < a.LiczbaWierszy; i++)
                    for (ushort j = 0; j < b.LiczbaKolumn; j++)
                        if (a.macierz[i, j] != b.macierz[i, j])
                            return false;
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(Macierz a, Macierz b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            //sprawdzenie parametru 'obj'
            if ((obj is null) || (!(obj is Macierz)))
                return false;
            //pomocnicza deklaracja zmiennej referencyjnej klasy Macierz
            Macierz m = (Macierz)obj;
            for (ushort i = 0; i < m.LiczbaWierszy; i++)
                for (ushort j = 0; j < m.LiczbaKolumn; j++)
                    if (this.macierz[i, j] != m[i, j])
                        return false;
            return true;
        }
        public override int GetHashCode()
        {
            return this.macierz.GetHashCode();
        }

        public static explicit operator Macierz (float x)
        {
            //deklaracja macierzy pomocniczej
            Macierz c = new Macierz(1, 1);
            //wpisanie wartości parametru 'x' do macierzy 'c'
            c.macierz[0, 0] = x;
            return c;
        }
    }
}
