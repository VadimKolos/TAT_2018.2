using System;
namespace ControlWork1
{
    /// <summary>
    /// Class EntryPoint is an entry point in the program.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SymbolCounter count = new SymbolCounter();
                if (args[0] == string.Empty)
                {
                    Console.WriteLine("Input string is empty!");
                }
                else
                {
                    count.Counter(args[0]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("incorrect input");
            }
        }
    }
}
