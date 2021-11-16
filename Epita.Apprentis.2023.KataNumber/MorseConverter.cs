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

        static int morseSize = morseTable[0].Length;
        static Dictionary<string, int> morseDictionnary = new Dictionary<string, int>();

        static MorseConverter()
        {
            int i = 0;
            foreach (var morse in morseTable)
            {
                morseDictionnary[morse] = i++;
            }
        }

        public string FromMorse(string morse)
        {
            StringBuilder number = new StringBuilder();

            for (int i = 0; i < morse.Length; i += morseSize)
            {
                string singleNumber = morse.Substring(i, morseSize);
                number.Append(morseDictionnary[singleNumber]);
            }

            return number.ToString();
        }

        public string ToMorse(string number)
        {
            StringBuilder builder = new StringBuilder();
            int i = 0;
            while (i < number.Length)
            {
                int digit = number[i++] - '0';
                builder.Append(morseTable[digit]);
            }

            return builder.Length > 0 ? builder.ToString() : morseTable[0];
        }
    }
}
