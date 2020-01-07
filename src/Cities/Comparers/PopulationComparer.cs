using System;
using System.Collections.Generic;

namespace Cities.Comparers
{
    public class PopulationComparer : IComparer<City>
    {

        public int Compare(City x, City y)
        {
            //x.Population == 50
            //y.Population == 15
            //what should compare return (neg. num if x is bigger than y)
            //return -1 when x > y

            //return x.CompareTo(y);


            if (x.Population > y.Population)
            {
                return -1;
            }
            else if (x.Population == y.Population)
            {
                return 0;
            }
            else
            {
                return 1;
            }


        }
    }
}
