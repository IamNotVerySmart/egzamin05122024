using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egzamin0512
{
    internal class osoba
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Pay {  get; set; }

        public osoba(string name, string surname, int pay)
        {
            Name = name;
            Surname = surname;
            Pay = pay;
        }

        public string ToString()
        {
            return this.Name + "," + this.Surname + "," + this.Pay;
        }

        public static List<osoba> humans(List<osoba> osobas)
        {
            List<osoba> humans = new List<osoba>();
            foreach (osoba a in osobas)
            {
                if (a.Pay > 5000)
                {
                    humans.Add(a);
                }
            }
            return humans;
        }


    }
}
