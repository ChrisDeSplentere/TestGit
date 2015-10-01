using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Pupil élève = new Pupil("Chris",6);
            Activity act1 = new Activity("Math",true);
            Activity act2 = new Activity("Français", true);
            Activity act3 = new Activity("Sciences", true);
            Activity act4 = new Activity("Religion", false);
            élève.AddActivity(act1);
            élève.AddActivity(act2);
            élève.AddActivity(act3);
            élève.AddActivity(act4);
            élève.AddEvaluation("Math");
            //System.Console.Write(élève);
            //System.Console.Write(élève.PrintPupilActivityCompulsory (delegate(Activity activity) {return activity.Title+"\n";}) );
            //System.Console.Write(élève.PrintPupilActivityCompulsory(PrintActivity));
            PrintActivityDelegate p = new PrintActivityDelegate();
            System.Console.Write(élève.PrintPupilActivityCompulsory(p.PrintActivity));
            System.Console.Read();

            /*List<Pupil> LstEleves = new List<Pupil>()
            {
                new Pupil("Chris",6),
                new Pupil("Jean",7,2),
                new Pupil("John",8,3),
                new Pupil("Jack",7),
                new Pupil("Jojo",7,2),
                new Pupil("Jeff",8)
            };*/

            /*var pupilGrade1Plus6 = from pupil in LstEleves
                                   where pupil.Grade == 1 && pupil.Age > 6
                                   select pupil;*/

            /*var pupilGrade1Plus6 = LstEleves.Where(pupil => pupil.Grade == 1 && pupil.Age > 6);

            if (pupilGrade1Plus6 != null) 
            {
                foreach (var élève in pupilGrade1Plus6)
                {
                    System.Console.Write(élève);
                    System.Console.Write("\n");
                }
            }
            System.Console.Read();*/

            /*List<Pupil> listPupils = new List<Pupil>()
            {
                new Pupil("Chris",6),
                new Pupil("Jean",7,2),
                new Pupil("John",8,3),
                new Pupil("Jack",7),
                new Pupil("Jojo",7,2),
                new Pupil("Jeff",8)
            };

            List<Person> listPersons = new List<Person>()
            {
                new Person("Christian",46),
                new Person("Jean-Noel",47),
                new Person("Johnson",48)
            };

            var listFusion = listPersons.Union(listPupils);

            foreach (var pers in listFusion)
            {
                System.Console.Write(pers);
                System.Console.Write("\n");
            }
            System.Console.Read();*/

            /*List<Pupil> listPupilsDuplicated = new List<Pupil>()
            {
                new Pupil("Chris",6),
                new Pupil("Chris",6),
                new Pupil("Jack",7),
                new Pupil("Jack",7)
            };
            IEnumerable<Pupil> listPupilsNoDuplicated = listPupilsDuplicated.Distinct<Pupil>(new PersonComparer());
            System.Console.Write(listPupilsNoDuplicated.Count());
            System.Console.Read();*/
        }

        private static string PrintActivity(Activity activity)
        {
            return activity.Title + "\n";
        }

    }
}
