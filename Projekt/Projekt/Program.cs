using System;

class Program
{
    static void Main(string[] args)
    {
        EvidencePojisteni evidence = new EvidencePojisteni();

        while (true)
        {
            Console.WriteLine("1 - Vytvořit pojištěného");
            Console.WriteLine("2 - Zobrazit seznam pojištěných");
            Console.WriteLine("3 - Vyhledat pojištěného podle jména a příjmení");
            Console.WriteLine("0 - Konec");

            string volba = Console.ReadLine();

            switch (volba)
            {
                case "1":
                    Console.WriteLine("Zadejte jméno pojistného:");
                    string jmeno = Console.ReadLine();

                    Console.WriteLine("Zadejte příjmení:");
                    string prijmeni = Console.ReadLine();

                    Console.WriteLine("Zadejte věk:");
                    int vek = int.Parse(Console.ReadLine());

                    Console.WriteLine("Zadejte telefonní číslo:");
                    string telefon = Console.ReadLine();

                    PojistenaOsoba novaOsoba = new PojistenaOsoba(jmeno, prijmeni, vek, telefon);
                    evidence.PridatPojisteneho(novaOsoba);
                    break;

                case "2":
                    evidence.ZobrazSeznamPojistenych();
                    break;

                case "3":
                    Console.WriteLine("Zadejte jméno:");
                    jmeno = Console.ReadLine();

                    Console.WriteLine("Zadejte příjmení:");
                    prijmeni = Console.ReadLine();

                    List<PojistenaOsoba> hledanaOsoba = evidence.NajitPojisteneho(jmeno, prijmeni);
                    if (hledanaOsoba != null)
                    {
                        Console.WriteLine("Nalezená osoba:");
                        foreach (PojistenaOsoba osoba in hledanaOsoba) 
                        { 
                            Console.WriteLine(osoba.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Osoba nenalezena.");
                    }
                    break;

                case "0":
                    Console.WriteLine("Konec programu.");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Neplatná volba.");
                    break;
            }
        }
    }
}