// See https://aka.ms/new-console-template for more information
using ListaIndirizzi;
using System.IO;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();
//   C:\\Utenti\\Utente\\Desktop\\ExGitVSCode\\ListaIndirizzi\\Indirizzi.txt

string percorso = "C:\\Users\\Utente\\Desktop\\ExGitVSCode\\ListaIndirizzi\\Indirizzi.txt";

// FileStream file = File.Open(percorso, FileMode.Create);  INUTILE
try
{
    StreamWriter sw = new StreamWriter(percorso);

    sw.WriteLine("Name,Surname,Street,City,Province,ZIP");
    sw.WriteLine("John,Doe,120 jefferson st.,Riverside,NJ,08075");
    sw.WriteLine("Jack,McGinnis,220 hobo Av.,Phila,PA,09119");
    sw.WriteLine("John Da Man, Repici,120 Jefferson St., Riverside, NJ,08075");
    sw.WriteLine("Stephen, Tyler,7452 Terrace \"At the Plaza\" road, SomeTown, SD,91234");



sw.Close();
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}

try
{
    StreamReader sr = new StreamReader(percorso);

    while (!sr.EndOfStream)
    {
        string riga = sr.ReadLine();


        string[] informazioniBrano = riga.Split(",");

        string name = informazioniBrano[0];
        string surname = informazioniBrano[1];
        string street = informazioniBrano[2];
        string city = informazioniBrano[3];
        string province = informazioniBrano[4];
        string zip = informazioniBrano[5];


        Indirizzo IndirizzoEstratto = new Indirizzo(name, surname, street, city, province, zip);
        listaIndirizzi.Add(IndirizzoEstratto);
        // Console.WriteLine(riga);
    }

    sr.Close();

}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}






foreach (Indirizzo brano in listaIndirizzi)
{
    Console.WriteLine(brano);
}