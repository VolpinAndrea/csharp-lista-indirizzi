using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    internal class Indirizzo
    {
        // ATTRIBUTI Name,Surname,Street,City,Province,ZIP
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private string zip;

        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {
            SetNome(name);
            SetCognome(surname);
            SetStrada(street);
            SetCittà(city);
            SetProvincia(province);
            SetZip(zip);
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetStreet()
        {
            return street;
        }
        public string GetCity()
        {
            return city;
        }
        public string GetProvince()
        {
            return province;
        }
        public string GetZip()
        {
            return zip;
        }
        public void SetNome(string nome)
        {
            if(nome == "")
            {
                this.name = "Non inserito";
            }
            else
            {
                this.name = nome;
            }
        }
        public void SetCognome(string cognome)
        {
            if (cognome == "")
            {
                this.name = "Non inserito";
            }
            else
            {
                this.surname = cognome;
            }
        }
        public void SetStrada(string strada)
        {
            if ( strada == "")
            {
                this.street = "Non inserito";
            }
            else
            {
                this.street = strada;
            }
        }
        public void SetCittà(string citta)
        {
            if ( citta == "")
            {
                this.city = "Non inserito";
            }
            else
            {
                this.city = citta;
            }
        }
        public void SetProvincia(string provincia)
        {
            if ( provincia == "")
            {
                this.province = "Non inserito";
            }
            else
            {
                this.province = provincia;
            }
        }
        public void SetZip(string zip)
        {
            if (zip == "")
            {
                this.zip = "Non inserito";
            }
            else
            {
                this.zip = zip;
            }
        }


        public override string ToString()
        {
            return "Nome: " + this.name + "\tCognome: " + this.surname + "\nVia: " + this.street + "   Città: " + this.city + "   Provincia: " + this.province + "\nZIP: " + this.zip + "\n--------------------------------------------------";
        }


    }
}

