using System;
using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var factors = GetFactors(number);

        if (factors.Contains(3) && factors.Contains(5) && factors.Contains(7))
        {
            return "PlingPlangPlong";
        }
        else if (factors.Contains(3) && factors.Contains(5))
        {
            return "PlingPlang";
        }
        else if (factors.Contains(3) && factors.Contains(7))
        {
            return "PlingPlong";
        }
        else if (factors.Contains(5) && factors.Contains(7))
        {
            return "PlangPlong";
        }
        else if (factors.Contains(3))
        {
            return "Pling";
        }
        else if (factors.Contains(5))
        {
            return "Plang";
        }
        else if (factors.Contains(7))
        {
            return "Plong";
        }
        else
        {
            return number.ToString();
        }
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