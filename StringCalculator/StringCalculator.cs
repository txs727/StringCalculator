
namespace StringCalculator
{
    public static class StringCalculator
    {
        public static int Add(string input)
        {
            if (IsNumeric(input))
            {
                return input == "" ? 0 : int.Parse(input);
            }


            var numbers = GetNumbers(input);

            return numbers.Sum(number => int.Parse(number));
        }

        private static string[] GetNumbers(string input)
        {
            if (input.Contains(','))
            return input.Split(',');

            return input.Split('\n');
        }

        private static bool IsNumeric(string input)
        {
            bool success = int.TryParse(input, out _);

            return input == "" || success;
        }
    }
}
