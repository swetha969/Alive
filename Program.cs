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
                    for(int i= prsn.YearBorn; i<= prsn.YearDied;i++)
                    {
                       aliveYrs.Add(i);
                    }
                }
            }

            var counts = aliveYrs
                        .GroupBy(item => item)
                        .Select(grp => new { Number = grp.Key, Count = grp.Count() });

            int maxCount = counts.Max(s => s.Count);

            List<int> maxAliveYrs = aliveYrs.GroupBy(x => x).Where(x => x.Count() == maxCount).Select(x => x.Key).ToList<int>();

            string strMostAliveYrs = string.Empty;

            if (maxAliveYrs.Count > 0)
            {
                foreach (int yr in maxAliveYrs)
                {
                    if (strMostAliveYrs.IndexOf(yr.ToString()) < 0)
                    {
                        if (strMostAliveYrs == string.Empty)
                            strMostAliveYrs = yr.ToString();
                        else
                            strMostAliveYrs = strMostAliveYrs + "," + yr.ToString();
                    }
                }

                if (maxAliveYrs.Count == 1)
                {
                    Console.WriteLine("Max people are alive in year : " + strMostAliveYrs);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Max people are alive in years : " + strMostAliveYrs);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Date Issue");
                Console.ReadLine();
            }
        }
    }
}
