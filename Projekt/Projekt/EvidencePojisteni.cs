using System;
using System.Collections.Generic;
using System.Linq;

public class EvidencePojisteni
{
    private List<PojistenaOsoba> seznamPojistenych;

    public EvidencePojisteni()
    {
        seznamPojistenych = new List<PojistenaOsoba>();
    }

    public void PridatPojisteneho(PojistenaOsoba osoba)
    {
        seznamPojistenych.Add(osoba);
    }

    public void ZobrazSeznamPojistenych()
    {
        Console.WriteLine("Seznam pojištěných osob:");
        foreach (var osoba in seznamPojistenych)
        {
            Console.WriteLine(osoba.ToString());
        }
    }

    public List<PojistenaOsoba> NajitPojisteneho(string jmeno, string prijmeni)
    {
        Console.WriteLine("Seznam pojištěných osob:");
        return seznamPojistenych.FindAll(e => e.Jmeno.StartsWith(jmeno) && e.Prijmeni.StartsWith(prijmeni)) ;
    }
}