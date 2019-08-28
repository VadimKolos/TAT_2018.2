using System;
using System.Linq;

namespace ControlWork1
{
    class SymbolCounter
    {
        public string Counter(string inputString)
        {
            /// <summary>
            /// The Method "Counter" counts repeating symbolss 
            /// displays them and their count.
            /// </summary>
            int countOfRepeatingSymbols = 0;
            char previousSymbol = '\\';
            foreach (char symbol in inputString.Distinct())
            { 
              foreach (char currentSymbol in inputString)
              if (currentSymbol != previousSymbol && currentSymbol == symbol)
              countOfRepeatingSymbols++;
              if (countOfRepeatingSymbols != 1 && symbol != previousSymbol)
              Console.WriteLine("Count of symbols " + symbol + " = " + countOfRepeatingSymbols);
              countOfRepeatingSymbols = 0;
              previousSymbol  = symbol;
            }
            Console.ReadLine();
            return inputString;
        }
    }
}
