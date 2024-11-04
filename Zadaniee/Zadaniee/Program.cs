using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dane pracowników");

            Pracownik pracownik1 = new Pracownik(4000, "Jan", "Kowalski", 000000); //Tworzy nowy obiekt

            Console.WriteLine(pracownik1.Imie, pracownik1.Nazwisko, pracownik1.Wiek , "Pesel Prywatny :(");

            Console.ReadKey();
        }
    }
    class Pracownik
    {
        private int wiek; //Uniemożliwia wyświetlanie i edycje
        public string Imie;
        public string Nazwisko; 
        private double Pesel; //Uniemożliwia wyświetlanie i edycje

        public Pracownik(int wiek, string imie, string nazwisko, double pesel)
        {
            Wiek = wiek;
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
        }


        public int Wiek //Zawiera getter i setter. Chroni przed dodaniem za dużej wartości
        {
            get { return wiek; } //Odczytuje wpisane dane
            set //Ustawia dane z ochroną przed ustawieniem za dużej wartości
            { 
                if (value > 130)
                {
                    Console.WriteLine("Wiek nie może być większy niż 130 lat bo tak");
                    wiek = 129;
                }
                wiek = value;
            
            }
        }
    }
}
