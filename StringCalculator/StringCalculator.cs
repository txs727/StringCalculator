
namespace StringCalculator
{
    public static class StringCalculator
    {
        public static int Add(string input)
        {
            if (input.Contains(","))
            {
                var numbers = input.Split(',');

                return numbers.Sum(number => int.Parse(number));
            }

            return string.IsNullOrEmpty(input) ? 0 : int.Parse(input);
        }
    }
}
