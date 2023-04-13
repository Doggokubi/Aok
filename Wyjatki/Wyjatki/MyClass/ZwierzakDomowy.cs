using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki.MyClass
{
    internal class ZwierzakDomowy
    {
        public string nazwa;
        public string gatunek;
        public DateTime dataUrodzenia;
        public ZwierzakDomowy(string nazwa, string gatunek, DateTime dataUrodzenia)
        { 
            this.nazwa = nazwa;
            this.gatunek = gatunek;
            this.dataUrodzenia = dataUrodzenia;
        }
        public int ObliczWiek()
        {
            if (dataUrodzenia > DateTime.Now)
                throw new Exception("Błąd: Twój zwierzak JESZCZE nie żyje");
            int wiek  = DateTime.Now.Year - dataUrodzenia.Year ;
            if (wiek > 25)
                throw new Exception("Błąd: Twój zwierzak CHYBA nie żyje");
            return wiek;
        }
        public override string ToString()
        {
            try
            {
                return $"Nazwa: {nazwa}\nGatunek: {gatunek}\nWiek: {ObliczWiek()}";
            }
            catch (Exception exc)
            {
                return $"{exc.Message}";
            }
        }
    }
}
