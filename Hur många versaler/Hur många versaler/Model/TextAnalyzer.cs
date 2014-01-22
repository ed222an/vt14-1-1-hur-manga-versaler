using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hur_många_versaler.Model
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text)
        {
            // Variabler
            int count = 0;

            //Loopar ingenom den medskickade texten och ökar count med 1 för varje versal.
            foreach (char c in text)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }

            // Returnerar counts värde.
            return count;
        }
    }
}