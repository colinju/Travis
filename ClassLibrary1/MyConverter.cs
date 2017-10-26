using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class MyConverter
    {
        
        public int Convert(String s)
        {
            char[] roman = s.ToCharArray();
            Dictionary<char, short> lookup = new Dictionary<char, short>();
            lookup.Add('M', 1000);
            lookup.Add('D', 500);
            lookup.Add('C', 100);
            lookup.Add('L', 50);
            lookup.Add('X', 10);
            lookup.Add('V', 5);
            lookup.Add('I', 1);
            lookup.Add('m', 1000);
            lookup.Add('d', 1000);
            lookup.Add('c', 100);
            lookup.Add('l', 50);
            lookup.Add('x', 10);
            lookup.Add('v', 5);
            lookup.Add('i', 1);

            int arabic = 0;

            for (int i = 0; i < roman.Count(); i++)
            {
                if (!lookup.ContainsKey(roman[i]))
                    throw new Exception("Nombre incorrect !");

                if (i == roman.Count() - 1)
                {
                    arabic += lookup[roman[i]];
                }
                else
                {
                    if (lookup[roman[i + 1]] > lookup[roman[i]]) arabic -= lookup[roman[i]];
                    else arabic += lookup[roman[i]];
                }
            }
            return arabic;
        }
    }
}
