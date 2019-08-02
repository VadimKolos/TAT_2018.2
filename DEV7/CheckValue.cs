using System;

namespace DEV7
{
    /// <summary>
    /// The CheckInput class check inputed strings for the presence of value and system only from 2 to 20.
    /// </summary>
    public class CheckValue
    {
        /// <summary> 
        /// Method CheckForCorrectInput
        /// function for check inputed strings for the presence of value of only integer and system only from 2 to 20.
        /// </summary> 
        /// <param name="inputValue">Value in deciml system</param>
        /// <param name="inputCountOfSystem">Number of system to convert</param>
        const int minCountSystem = 2;
        const int maxCountSystem = 20;
        public bool CheckCorrectValues(string inputValue, int CountSystem)
        {
            bool returnValue = false;  //return false or true if input incorrect or correct respectively
                                       //checking for empty input; checking for range of number of system.
            if ((inputValue.Length > 0 && CountSystem > 0) && (CountSystem >= minCountSystem && Convert.ToInt32(CountSystem) <= maxCountSystem))
            {
                returnValue = true;
            }
            return returnValue; //return bool value.
        }
    }
}
