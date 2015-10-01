using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*PrivateContact Jean = new PrivateContact("Jean","Robert",0123456789,"jeanrobert@hotmail.com");
            PrivateContact Chris = new PrivateContact("Chris","DS",0494121212,"chrisds@hotmail.com",DateTime.Today);

            if (Jean.BirthdayWish())
            {
                System.Console.Write(Jean + " Bon anniversaire!");
                System.Console.Read();
            }

            if (Chris.BirthdayWish())
            {
                System.Console.Write(Chris + " Bon anniversaire!");
                System.Console.Read();
            }*/


            ProfessionalContact André = new ProfessionalContact("André", "VanKe", "Consultant", 0494111111, "André.VanKe@hotmail.com");
            ProfessionalContact Mike = new ProfessionalContact("Mike", "Anderlin", "Consultant", 0494222222, "Mike.Anderlin@hotmail.com");
            ProfessionalContact Isa = new ProfessionalContact("Isabelle", "Charlier", "Indépendant", 0494333333, "Isa.Charlier@hotmail.com");

            Entreprise Microsoft = new Entreprise("Microsoft","Bruxelles");
            Entreprise SAP = new Entreprise("SAP", "Namur");

            André.EntrepriseAdd(Microsoft);
            André.EntrepriseAdd(SAP);
            Mike.EntrepriseAdd(Microsoft);

            List<ProfessionalContact> listPro = new List<ProfessionalContact>();
            listPro.Add(André);
            listPro.Add(Mike);
            listPro.Add(Isa);

            var listInd = from pro in listPro
                          where pro.Profession == "Indépendant"
                          select pro;
            System.Console.Write(listInd.Count() + " indépendant(s)\n");

            var listProMicrosoft = listPro.Where(pro => pro.Profession == "Consultant" && pro.Entreprises.Contains(Microsoft));
            foreach (var pro in listProMicrosoft)
            {
                System.Console.Write(pro);
                System.Console.Write("\n");
            }
            System.Console.Read();

        }
    }
}
