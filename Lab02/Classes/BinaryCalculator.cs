using System;

namespace Lab02
{
    public static class BinaryCalculator
    {
        /// Проверяет, является ли строка корректным двоичным числом.
        private static bool IsValidBinary(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            foreach (char c in s)
                if (c != '0' && c != '1') return false;
            return true;
        }

        /// Складывает два двоичных числа и возвращает результат в двоичной и десятичной форме.
        public static bool AddBinary(string bin1, string bin2, out string binaryResult, out long decimalResult)
        {
            binaryResult = null;
            decimalResult = 0;

            if (!IsValidBinary(bin1) || !IsValidBinary(bin2))
                return false;

            try
            {
                long num1 = Convert.ToInt64(bin1, 2);
                long num2 = Convert.ToInt64(bin2, 2);
                decimalResult = num1 + num2;
                binaryResult = Convert.ToString(decimalResult, 2);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}