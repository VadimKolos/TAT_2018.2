using System;
namespace DEV7
{
    /// <summary>
    /// The NewSystem method takes 2 strings of numbes. The first one is a value.
    /// in a decimal system, the the second is a number of system to be transferred. That metod convert number(1st value)
    /// from decimal to another number (2nd value) system.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Entry point of the program
            // The entry point of the program, where the program control starts and ends.  
            // Get the values from the command line argument.
            try
            {
                NewSystem system = new NewSystem();
                CheckValue checkInputVal = new CheckValue();
                int inputValue = Convert.ToInt32(args[0]);
                int countOfSystemInt = Convert.ToInt32(args[1]);
                //check input value of system which would be between 2 and 20  
                if (countOfSystemInt <= 20 && countOfSystemInt >= 2 &&checkInputVal.CheckCorrectValues(args[0], countOfSystemInt))
                {
                    string input_value = system.ConvertCountSystem(args[0], countOfSystemInt);
                    Console.WriteLine(input_value);
                }
              
                else
                {
                    Console.WriteLine("incorrect input");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("incorrect input");
            }
        }
    }
}
