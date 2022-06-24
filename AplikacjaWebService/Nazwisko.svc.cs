using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AplikacjaWebService
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie, usłudze i pliku konfiguracji.
    // UWAGA: aby uruchomić klienta testowego WCF w celu przetestowania tej usługi, wybierz plik Service1.svc lub Service1.svc.cs w eksploratorze rozwiązań i rozpocznij debugowanie.
    public class Service1 : INazwisko
    {
        public string WyszukajKlienta(string nazwisko)
        {
            List<Klient> klienci = new List<Klient>();

            Klient k1 = new Klient("Maciej","Adamczyk","Kraków Konstantynopolska 55");
            Klient k2 = new Klient("Adam", "Przybysz", "Gdańsk Metropolitanska 43");
            Klient k3 = new Klient("Grzegorz", "Nowak", "Gdańsk Grunwaldzka 33");
            Klient k4 = new Klient("Ryszard", "Kowalski", "Wrocław Gdańska 21");
            Klient k5 = new Klient("Tomasz", "Peja", "Poznań Tedego 44");
            Klient k6 = new Klient("Szymon", "Marcinski", "Gdańsk Grottgera 37");
            
            klienci.Add(k1); klienci.Add(k2);
            klienci.Add(k3); klienci.Add(k4);
            klienci.Add(k5); klienci.Add(k6);

            Klient szukany = klienci.Find(i => i.Nazwisko == nazwisko);
            if (szukany != null)
            {
                return szukany.Imie + " " + szukany.Nazwisko + " " + szukany.Adres;
            }
            else 
            {
                return "Brak klienta w bazie o takim nazwisku";
            }
            
        }

        public class Klient
        {
            public string Imie { set; get; }
            public string Nazwisko { set; get; }
            public string Adres { set; get; }
            public Klient(string imie, string nazwisko, string adres)
            {
                (Imie, Nazwisko, Adres) = (imie, nazwisko, adres);
            }

            public void Wypisz() 
            {
                Console.WriteLine("Imie: " + Imie + " Nazwisko: " + Nazwisko + " Adres: " + Adres);
            }
        }
    }
}
