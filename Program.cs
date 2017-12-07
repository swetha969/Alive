using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MaxAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            List<Person> lstPrsn = person.GetPersons();
            List<int> aliveYrs = new List<int>();

            foreach(Person prsn in lstPrsn)
            {
                if(prsn.YearBorn < prsn.YearDied && prsn.YearBorn>=1900 && prsn.YearDied<=2000)
                {
                    for(int i= prsn.YearBorn; i<prsn.YearDied;i++)
                    {
                       aliveYrs.Add(i);
                    }
                }
            }

            int maxPeopleAlive = aliveYrs.GroupBy(s => s)
                         .OrderByDescending(s => s.Count())
                         .First().Key;

            Console.WriteLine("Max people are alive in year " + maxPeopleAlive);



        }
    }
}
