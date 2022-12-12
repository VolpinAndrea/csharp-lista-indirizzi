// See https://aka.ms/new-console-template for more information
using ListaIndirizzi;
using System.IO;
using System.Xml.Linq;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();
//   C:\\Utenti\\Utente\\Desktop\\ExGitVSCode\\ListaIndirizzi\\Indirizzi.txt


StreamReader file = File.OpenText("C:\\Users\\Utente\\Desktop\\ExGitVSCode\\ListaIndirizzi\\Indirizzi.txt");

file.WriteLines("");
file.Close();



while (!file.EndOfStream)
    {
        string riga = file.ReadLine();


        string[] informazioniBrano = riga.Split(",");
         
        string name = informazioniBrano[0];
        string surname = informazioniBrano[1];
        string street = informazioniBrano[2];
        string city = informazioniBrano[3];
        string province = informazioniBrano[4];
        string zip = informazioniBrano[5];


        Indirizzo branoEstratto = new Indirizzo(name, surname, street, city, province, zip);
        listaIndirizzi.Add(branoEstratto);
        // Console.WriteLine(riga);
    }

    file.Close();



foreach (Indirizzo brano in listaIndirizzi)
{
    Console.WriteLine(brano);
}