using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zadanie 1");
        Samochod s1 = new Samochod("Toyota", "Avensis", 2008);
        Samochod s2 = new Samochod("BMW", "M4", 2018);
        s1.WyswietlInformacje();
        s2.WyswietlInformacje();

        Console.WriteLine("\nZadanie 2");
        Uczen u1 = new Uczen("Jarek", "Niewiadomski", 5.5);
        Uczen u2 = new Uczen("Karol", "Nawrocki", 1.7);
        Uczen u3 = new Uczen("Maks", "Trzaskowski", 3.0);
        u1.PokazUcznia();
        u2.PokazUcznia();
        u3.PokazUcznia();

        Console.WriteLine("\nZadanie 3");
        Pracownik p = new Pracownik("Jan", "Kowalsku", 4000);
        Kierownik k = new Kierownik("Maciej", "Nowacki", 7000, "IT");
        p.WyswietlInfo();
        k.WyswietlInfo();

        Console.WriteLine("\nZadanie 4");
        List<Produkt> produkty = new List<Produkt>();
        produkty.Add(new Produkt("Chipsy", 6.7, 2));
        produkty.Add(new Produkt("Mleko", 3.2, 3));
        produkty.Add(new Produkt("Masło", 8.0, 1));

        double suma = 0;
        foreach (var prod in produkty)
        {
            prod.PokazProdukt();
            suma += prod.Cena * prod.Ilosc;
        }

        Console.WriteLine($"Łączna wartość: {suma}");
    }
}

class Samochod
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int RokProdukcji { get; set; }

    public Samochod(string marka, string model, int rok)
    {
        Marka = marka;
        Model = model;
        RokProdukcji = rok;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, Rok: {RokProdukcji}");
        if (DateTime.Now.Year - RokProdukcji > 10)
            Console.WriteLine("Samochód ma więcej niż 10 lat");
        else
            Console.WriteLine("Samochód ma 10 lat lub mniej");
    }
}

class Uczen
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public double Srednia { get; set; }

    public Uczen(string imie, string nazwisko, double srednia)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Srednia = srednia;
    }

    public bool CzyZdaje()
    {
        return Srednia >= 2.0;
    }

    public void PokazUcznia()
    {
        Console.WriteLine($"Uczen: {Imie} {Nazwisko}, Średnia: {Srednia}, Zdaje: {CzyZdaje()}");
    }
}

class Pracownik
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public double Wynagrodzenie { get; set; }

    public Pracownik(string imie, string nazwisko, double wynagrodzenie)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Wynagrodzenie = wynagrodzenie;
    }

    public virtual void WyswietlInfo()
    {
        Console.WriteLine($"Pracownik: {Imie} {Nazwisko}, Pensja: {Wynagrodzenie}");
    }
}

class Kierownik : Pracownik
{
    public string Dzial { get; set; }

    public Kierownik(string imie, string nazwisko, double wynagrodzenie, string dzial)
        : base(imie, nazwisko, wynagrodzenie)
    {
        Dzial = dzial;
    }

    public override void WyswietlInfo()
    {
        Console.WriteLine($"Kierownik: {Imie} {Nazwisko}, Pensja: {Wynagrodzenie}, Dział: {Dzial}");
    }
}

class Produkt
{
    public string Nazwa { get; set; }
    public double Cena { get; set; }
    public int Ilosc { get; set; }

    public Produkt(string nazwa, double cena, int ilosc)
    {
        Nazwa = nazwa;
        Cena = cena;
        Ilosc = ilosc;
    }

    public void PokazProdukt()
    {
        Console.WriteLine($"Produkt: {Nazwa}, Cena: {Cena}, Ilość: {Ilosc}");
    }
}