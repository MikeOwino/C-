using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
         {  
      // Your Age
      int userAge = 23;


      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;


      // Age on Jupiter
      double jupiterAge = userAge / jupiterYears;


      // Time to Jupiter
      double journeyToJupiter = 6.142466;
      // New Age on Earth

      double newEarthAge = userAge + journeyToJupiter;


      // New Age on Jupiter

      double newJupiterAge = newEarthAge/jupiterYears;


      // Log calculations to console
      Console.WriteLine(jupiterAge);
      Console.WriteLine(newEarthAge);
      Console.WriteLine(newJupiterAge);
        }
    }
}