using System;

namespace Epita.Apprentis._2023.KataNumber
{
    class ConsoleAdapter : IOAdapter
    {
        public string Read()
        {
            Console.Write("> ");
            return Console.ReadLine();
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
