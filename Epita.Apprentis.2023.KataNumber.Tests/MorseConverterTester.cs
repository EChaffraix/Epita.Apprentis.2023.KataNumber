using NUnit.Framework;

namespace Epita.Apprentis._2023.KataNumber.Tests
{
    [TestFixture]
    public class MorseConverterTester
    {
        public class MorseNumber
        {
            public string Number { get; set; }
            public string Morse { get; set; }

            public override string ToString()
            {
                return $"{Number}:{Morse}";
            }
        }
        static MorseNumber[] testcases = {
            new MorseNumber { Number= "1903", Morse= ". _ _ _ _ _ _ _ _ . _ _ _ _ _ . . . _ _ " },
            new MorseNumber { Number= "83", Morse= "_ _ _ . . . . . _ _ " },
            new MorseNumber { Number= "10", Morse= ". _ _ _ _ _ _ _ _ _ " },
            new MorseNumber { Number= "42", Morse= ". . . . _ . . _ _ _ " },
            new MorseNumber { Number= "999", Morse= "_ _ _ _ . _ _ _ _ . _ _ _ _ . " },
            new MorseNumber { Number= "1", Morse= ". _ _ _ _ " },
            new MorseNumber { Number= "2", Morse= ". . _ _ _ " },
            new MorseNumber { Number= "3", Morse= ". . . _ _ " },
            new MorseNumber { Number= "4", Morse= ". . . . _ " },
            new MorseNumber { Number= "5", Morse= ". . . . . " },
            new MorseNumber { Number= "6", Morse= "_ . . . . " },
            new MorseNumber { Number= "7", Morse= "_ _ . . . " },
            new MorseNumber { Number= "8", Morse= "_ _ _ . . " },
            new MorseNumber { Number= "9", Morse= "_ _ _ _ . " },
            new MorseNumber { Number= "0", Morse= "_ _ _ _ _ " },
            new MorseNumber { Number = "3216546213216854132169854132198413", Morse= ". . . _ _ . . _ _ _ . _ _ _ _ _ . . . . . . . . . . . . . _ _ . . . . . . _ _ _ . _ _ _ _ . . . _ _ . . _ _ _ . _ _ _ _ _ . . . . _ _ _ . . . . . . . . . . . _ . _ _ _ _ . . . _ _ . . _ _ _ . _ _ _ _ _ . . . . _ _ _ _ . _ _ _ . . . . . . . . . . . _ . _ _ _ _ . . . _ _ . . _ _ _ . _ _ _ _ _ _ _ _ . _ _ _ . . . . . . _ . _ _ _ _ . . . _ _"
"}
         };

        [TestCaseSource("testcases")]
        public void GivenANumber_Its_Morse_Representation_Is_Correct(MorseNumber testCase)
        {
            var converter = new MorseConverter();
            var result = converter.ToMorse(testCase.Number);
            Assert.That(result, Is.EqualTo(testCase.Morse));
        }

        [TestCaseSource("testcases")]
        public void GivenAMorseNumber_Its_Number_Representation_Is_Correct(MorseNumber testCase)
        {
            var converter = new MorseConverter();
            var result = converter.FromMorse(testCase.Morse);
            Assert.That(result, Is.EqualTo(testCase.Number));
        }
    }
}