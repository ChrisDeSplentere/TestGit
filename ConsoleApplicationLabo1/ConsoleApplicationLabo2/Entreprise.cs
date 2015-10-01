using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public class Entreprise
    {

        public String Nom { get; set; }

        public String Localité { get; set; }

        public Entreprise(String nom, String localité)
        {
            Nom = Nom;
            Localité = localité;
        }

        public override string ToString()
        {
            return Nom + " localisée à " + Localité;
        }

    }
}
