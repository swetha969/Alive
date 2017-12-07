using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxAlive
{
    public class Person
    {
        public int YearBorn; 
        public int YearDied; 
       

        public List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>
            {
                new Person { YearBorn=1905,YearDied=1965 },
                new Person { YearBorn=1985,YearDied=1995 },
                new Person { YearBorn=1910,YearDied=1975 },
                new Person { YearBorn=1915,YearDied=1998 },
                new Person { YearBorn=1987,YearDied=1999 },
                new Person { YearBorn=1906,YearDied=1988 },
                new Person { YearBorn=1903,YearDied=1956 },
                new Person { YearBorn=1926,YearDied=1999 },
                new Person { YearBorn=1919,YearDied=1987 },
                new Person { YearBorn=1947,YearDied=1986 },
                new Person { YearBorn=1965,YearDied=1995 },
                new Person { YearBorn=1966,YearDied=1997 },
                new Person { YearBorn=1909,YearDied=1928 },
                new Person { YearBorn=1904,YearDied=1965 },
                new Person { YearBorn=1954,YearDied=1998 },
            };
            return persons;
        }


        //Other properties, methods, events...
    }
}
