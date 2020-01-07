using System;
using System.Collections.Generic;

namespace Cities.Comparers
{
    public class AreaComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            //return x.Area.CompareTo(y.Area);
            //this returns the cities from lowest to highest, so to list Area from highest
            //to lowest you would need to do the opposite.
            return y.Area.CompareTo(x.Area);


            //This didn't have anything to compare the first row to so it returned the
            //row as true(that's why the first city appeared regardless of the area)
            //if (x.Area > y.Area)
            //{
            //    return -1;
            //}
            //else if (!(x.Area.Equals(y.Area)))
            //{
            //    return 0;
            //}
            //else
            //{
            //    return -1;
            //}


        }
    }
}
