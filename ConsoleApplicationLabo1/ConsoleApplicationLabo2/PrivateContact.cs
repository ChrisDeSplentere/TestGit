using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public class PrivateContact : Person
    {

        public int NumTel
        { get; set; }

        public String AdrMail
        { get; set; }

        public DateTime DateNaiss
        { get; set; }

        public PrivateContact(String name, String lastname, int numTel, String adrMail, DateTime dateNaiss) : this(name,lastname,numTel,adrMail)
        {
            DateNaiss = dateNaiss;
        }

        public PrivateContact(String name, String lastname, int numTel, String adrMail) : base(name,lastname)
        {
            NumTel = numTel;
            AdrMail = adrMail;
        }

        public override string ToString()
        {
            return base.ToString() + " (" + NumTel + ")\n" + AdrMail;
        }

        public override bool BirthdayWish()
        {
            return (DateTime.Today.Month == DateNaiss.Month && DateTime.Today.Day == DateNaiss.Day);
        }

    }
}
