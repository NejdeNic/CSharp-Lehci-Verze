using System;

public class PojistenaOsoba
{
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
    public int Vek { get; set; }
    public string Telefon { get; set; }

    public PojistenaOsoba(string jmeno, string prijmeni, int vek, string telefon)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
        Vek = vek;
        Telefon = telefon;
    }

    public override string ToString()
    {
        return $"Jméno: {Jmeno} {Prijmeni}, Věk: {Vek}, Telefon: {Telefon}";
    }
}