using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientatedprinciples
{
    class People
    {
        public string name;
        public int Age;
        public string Race;
        public string Gender;


        public People(string PersonName, string PersonGender, string PersonRace, int PersonAge)
        {
            name = PersonName;
            Age = PersonAge;
            Race = PersonRace;
            Gender = PersonGender;
        }
    }
}
