using System;
using System.Text;

namespace DEV7
{
    /// <summary>
    /// Class for convert input value to another number system.
    /// </summary>
    class NewSystem
    {
        /// <summary> 
        /// Method Convert_count_System.
        /// function convert from decimal system to another selected system.
        /// </summary> 
        string digitsOfTheSystem = "0123456789ABCDEFGHIJK";
       
        public string ConvertCountSystem(string inputValue, int countSystem)
        {
            StringBuilder convertedValue = new StringBuilder();
            //convert inputed strings into integer vaalues.
            int intValue = Convert.ToInt32(inputValue);
            int numberOfRadix = Convert.ToInt32(countSystem);
            //check for negative value 
            string sign = "";
            if (intValue < 0)
            {
                intValue = intValue * -1;
                sign = "-";
            }
            //transfer value from decimal to selected system.
            int i = 0;
            for (; ; )
            {
                if (intValue >= numberOfRadix)
                {
                    if (intValue % numberOfRadix == 0)
                    {
                        convertedValue.Insert(0, digitsOfTheSystem[0]);
                        intValue /= numberOfRadix;
                    }
                    else if (intValue % numberOfRadix > 0)
                    {
                        convertedValue.Insert(0, digitsOfTheSystem[intValue % numberOfRadix]);
                        intValue = intValue / numberOfRadix;
                    }
                }
                else if (intValue < numberOfRadix)
                {
                    convertedValue.Insert(0, digitsOfTheSystem[intValue]);
                    break;
                }
                i++;
            }
            convertedValue.Insert(0, sign);
            return convertedValue.ToString(); //return converted value.
        }
    }
}