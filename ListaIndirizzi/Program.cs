// See https://aka.ms/new-console-template for more information
using ListaIndirizzi;

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
    sw.WriteLine("Joan,Anne,Jet,9th at Terrace plc, Desert City,CO,00123");
    sw.WriteLine(",Blankman,,New York, NY, 100101");
    sw.WriteLine("Joan,SomeTown, SD, 00298");

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
        string riga = ControllaRiga(sr.ReadLine());




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

static string ControllaRiga(string riga)
{
    int virgole = riga.Count(f => f == ',');
    if (virgole > 5)
    {
        Console.WriteLine("entrtyuacfv");
        int index = riga.IndexOf(",");
        string nuova = riga.Replace(riga[index], ' ');
        Console.WriteLine(nuova);
        return nuova;
    }
    else
    {
        return riga;
    }


}

