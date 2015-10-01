using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public abstract class Person
    {

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String lastname;

        public String Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public Person(String name, String lastname)
        {
            Name = name;
            Lastname = lastname;
        }

        public override string ToString()
        {
            return Name + " " + Lastname;
        }

        public abstract bool BirthdayWish();

    }
}
