using System;
namespace DEV3
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
                int count_of_system_int = Convert.ToInt32(args[1]);
                //checking input value of system need value between 2 and 20  
                if (count_of_system_int < 20 && count_of_system_int >= 2)
                {
                    string input_value = system.Convert_count_System(args[0], count_of_system_int);
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