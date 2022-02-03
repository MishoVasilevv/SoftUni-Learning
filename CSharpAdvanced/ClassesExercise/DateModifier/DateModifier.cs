using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    class DateModifier
    {
        public static int DifferenceBetweenTwoDates(string firstDate, string secondDate)
        {
            DateTime dateOne = DateTime.Parse(firstDate);
            DateTime dateTwo = DateTime.Parse(secondDate);

            int difference = Math.Abs((dateOne - dateTwo).Days);

            return difference;
        }
    }
}
