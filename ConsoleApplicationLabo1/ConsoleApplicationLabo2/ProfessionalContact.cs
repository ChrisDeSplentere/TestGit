using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public class ProfessionalContact : Person
    {

        public String Profession { get; set; }

        public int NumTelProf { get; set; }

        public String AdrMailProf { get; set; }

        public List<Entreprise> Entreprises { get; set; }

        public ProfessionalContact(String name, String lastname, String profession, int numTelProf, String adrMailProf) : base(name,lastname)
        {
            Profession = profession;
            NumTelProf = numTelProf;
            AdrMailProf = adrMailProf;
            Entreprises = new List<Entreprise>();
        }

        public override string ToString()
        {
            return base.ToString() + " (" + NumTelProf + ")\n" + Profession + "\n" + AdrMailProf;
        }

        public override bool BirthdayWish()
        {
            return false;
        }

        public void EntrepriseAdd(Entreprise entreprise) 
        {
            Entreprises.Add(entreprise);
        }

    }
}
