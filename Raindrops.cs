using System;
using System.Collections.Generic;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var factors = GetFactors(number);

        if (factors.Count == 3)
        {
            return "Pling";
        } else if (factors.Count == 5) 
        {
            return "Plang";
        } else if (factors.Count == 7) {
            return "Plong";
        } else {
            return number.ToString();
        }
    }

    public static List<int> GetFactors(int number)
    {
        List<int> factors = new List<int>();
        int max = (int)Math.Sqrt(number);  //round down
        for (int factor = 1; factor <= max; ++factor)
        { //test from 1 to the square root, or the int below it, inclusive.
            if (number % factor == 0)
            {
                factors.Add(factor);
                if (factor != number / factor)
                { // Don't add the square root twice!  Thanks Jon
                    factors.Add(number / factor);
                }
            }
        }

        return factors;
    }
}