using System;
using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var factors = GetFactors(number);
        var phrase = "";

        if (factors.Contains(3))
        {
            phrase += "Pling";
        }

        if (factors.Contains(5))
        {
            phrase += "Plang";
        }

        if (factors.Contains(7))
        {
            phrase += "Plong";
        }

        return String.IsNullOrWhiteSpace(phrase) ? number.ToString() : phrase;
    }

    public static List<int> GetFactors(int number)
    {
        List<int> factors = new List<int>();
        int max = (int)Math.Sqrt(number);
        for (int factor = 1; factor <= max; ++factor)
        {
            if (number % factor == 0)
            {
                factors.Add(factor);

                if (factor != number / factor)
                {
                    factors.Add(number / factor);
                }
            }
        }

        return factors;
    }
}