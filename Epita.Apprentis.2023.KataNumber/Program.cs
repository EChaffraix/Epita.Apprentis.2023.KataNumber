using System;

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
                if (int.TryParse(message, out var number))
                {
                    var result = converter.ToMorse(number);
                    adapter.Write(result);
                } else if (string.Equals(message, "exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    @continue = false;
                }
            } while (@continue);

            Console.WriteLine("Bye!");
        }
    }
}
