
namespace StringCalculator
{
    public static class StringCalculator
    {
        public static int Add(string input)
        {
            var (success, result) = GetNumber(input);
            if (success)
            {
                return result;
            }
            
            var numbers = GetNumberStrings(input);

            return numbers.Sum(int.Parse);
        }

        private static string[] GetNumberStrings(string input)
        {
            if (input.StartsWith("//"))
            {
                var parsedInput = input.Split('\n');
                var delimiter = parsedInput[0][2];
                return parsedInput[1].Split(delimiter);
            }

            if (input.Contains(','))
                return input.Split(',');

            return input.Split('\n');
        }

        private static (bool success, int result) GetNumber(string input)
        {
            bool success = int.TryParse(input, out int result);

            return (input == "" || success, result);
        }
    }
}
