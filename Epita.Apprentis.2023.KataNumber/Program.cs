using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Epita.Apprentis._2023.KataNumber
{
    public class Program
    {
        private IOAdapter adapter;
        private IMorseConverter converter;

        public Program(IOAdapter adapter, IMorseConverter converter)
        {
            this.adapter = adapter;
            this.converter = converter;
        }

        static void Main(string[] args)
        {
            var adapter = new ConsoleAdapter();
            var converter = new MorseConverter();
            var program = new Program(adapter, converter);
            program.Run();
        }

        public void Run()
        {
            string message;
            bool @continue = true;
            do
            {
                message = adapter.Read();
                if (Regex.IsMatch(message, "[0-9]+"))
                {
                    var result = converter.ToMorse(message);
                    adapter.Write(result);
                } else if (string.Equals(message, "exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    @continue = false;
                } else if (message.Length % 10 == 0) {
                    var value = converter.FromMorse(message);
                    adapter.Write($"{value}");
                }
            } while (@continue);

            Console.WriteLine("Bye!");
        }
    }
}
