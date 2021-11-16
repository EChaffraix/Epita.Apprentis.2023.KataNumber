using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epita.Apprentis._2023.KataNumber
{
    public class MorseConverter : IMorseConverter
    {
        static string[] morseTable = new[]{
            "_ _ _ _ _ " ,
            ". _ _ _ _ " ,
            ". . _ _ _ " ,
            ". . . _ _ " ,
            ". . . . _ " ,
            ". . . . . " ,
            "_ . . . . " ,
            "_ _ . . . " ,
            "_ _ _ . . " ,
            "_ _ _ _ . "
        };

        public string ToMorse(int number)
        {
            StringBuilder builder = new StringBuilder();
            while (number > 0)
            {
                builder.Insert(0, morseTable[number % 10]);
                number /= 10;
            }

            return builder.Length > 0 ? builder.ToString() : morseTable[0];
        }
    }
}
