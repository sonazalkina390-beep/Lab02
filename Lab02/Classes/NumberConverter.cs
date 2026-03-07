using System;

namespace Lab02
{
    public static class NumberConverter
    {
        /// Преобразует неотрицательное целое число в строки: двоичную, восьмеричную, шестнадцатеричную.
        public static bool ConvertToAllSystems(long decimalValue, out string binary, out string octal, out string hex)
        {
            if (decimalValue < 0)
            {
                binary = octal = hex = null;
                return false;
            }

            binary = Convert.ToString(decimalValue, 2);
            octal = Convert.ToString(decimalValue, 8);
            hex = Convert.ToString(decimalValue, 16).ToUpper();
            return true;
        }
    }
}