using System;
namespace DEV3
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
        public string Convert_count_System(string input_value, int count_system)
        {
            /// <param name="input_value">Value in deciml system</param>
            /// <param name="count_system">Number of system to convert</param>
            string digits = "0123456789ABCDEFGHIJK";
            string result = null;
            int digit = 0;
            int converted_value=0;
            for (int i = input_value.Length - 1; i >= 0; i--)
            {
                digit = Convert.ToInt32(input_value[i]);
                if ((digit >= 48) && (digit <= 57))
                    digit = digit - 48;
                converted_value = converted_value + digit;             
            }
            //transfer value from decimal to selected system.
            while (converted_value != 0)
            {
                digit = converted_value % count_system;
                result = digits[digit] + result;
                converted_value = converted_value / count_system;
            }
            return result;
        }
    }
}
