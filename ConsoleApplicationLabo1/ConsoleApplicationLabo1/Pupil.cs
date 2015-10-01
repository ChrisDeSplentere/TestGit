using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Pupil : Person
    {

        public int Grade { get; set; }

        public List<Activity> LstActivities { get; set; }

        public char[] PupilEvaluations { get; set; }

        public delegate string DelegatePrintActivityCompulsory(Activity activity);

        /*private Dictionary<String, char> pupilActivities = new Dictionary<String, char>();

        public Dictionary<String, char> PupilActivities
        {
            get { return pupilActivities; }
            set { pupilActivities = value; }
        }*/

        public Pupil(String name, int age, int grade) : base(name,age) 
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            PupilEvaluations = new char[Parameter.MAXACT];
        }

        public Pupil(String name, int age) : this(name, age, 1)
        {}

        /*public void AddActivity(String activityTitle)
        {
            PupilActivities.Add(activityTitle, '0');
        }

        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            if (title != null) PupilActivities[title] = evaluation;
        }*/

        public override string ToString()
        {
            string ch = Header();
            ch = PrintActivities(ch);
            return ch;
        }

        /*private string PrintActivities(string ch)
        {
            int i;
            for (i = 0; i < PupilActivities.Count(); i++)
                ch += "\n" + PupilActivities.ElementAt(i).Key.ToString() + " : " +
                PupilActivities.ElementAt(i).Value;
            return ch;
        }
        private string Header()
        {
            return base.ToString() + ((PupilActivities.Count() != 0) ? " a choisi …\n" :
            " n’a pas encore choisi d’activité\n");
        }*/

        public void AddActivity(Activity activity)
        {
            LstActivities.Add(activity);
        }

        private string PrintActivities(string ch)
        {
            int i;
            for (i = 0; i < LstActivities.Count(); i++)
            {
                ch += " - " + LstActivities[i] + "\n";
            }

            return ch;
        }

        private string Header()
        {
            return base.ToString() + ((LstActivities.Count() != 0) ? " a choisi les activités : \n" : " n'a pas encore choisi d'activité.");
        }

        public void AddEvaluation(String title = null, char evaluation = (char)Parameter.EnumEval.Satisfaisant) 
        {
            int i = 0;
            if(title != null)
            {
                foreach (Activity activity in LstActivities)
                {
                    if (activity.Title.Equals(title)) break;
                    i++;
                }
                PupilEvaluations[i] = evaluation;
            }
        }


        public string PrintPupilActivityCompulsory(DelegatePrintActivityCompulsory MyPrintActivity)
        {
            int numActivity = 0;
            string ch = base.ToString() + " a choisi les activités obligatoires : \n";
            foreach (Activity activity in LstActivities)
                if (activity.Compulsory)
                    ch += (++numActivity) + " " + MyPrintActivity(activity);
            return ch;
        }




    }
}
