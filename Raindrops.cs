using System;
using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var phrase = "";

        if (number % 3 == 0)
        {
            phrase += "Pling";
        }

        if (number % 5 == 0)
        {
            phrase += "Plang";
        }

        if (number % 7 == 0)
        {
            phrase += "Plong";
        }

        return String.IsNullOrWhiteSpace(phrase) ? number.ToString() : phrase;
    }
}