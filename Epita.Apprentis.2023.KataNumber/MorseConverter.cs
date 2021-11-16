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

        static Dictionary<string, int> morseDictionnary = new Dictionary<string, int>();

        static MorseConverter(){
            int i = 0;
            foreach(var morse in morseTable){
                morseDictionnary[morse] = i++;
            }
        }

        public int FromMorse(string morse)
        {
            int number = 0;
            int morseSize = morseTable[0].Length;

            for( int i = 0; i < morse.Length; i += morseSize){
                string singleNumber = morse.Substring(i, morseSize);
                number = number * 10 + morseDictionnary[singleNumber];
            }

            return number;
        }

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
