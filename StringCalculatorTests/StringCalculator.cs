using StringCalculator;

namespace StringCalculatorTests
{
    public class StringCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_PassedEmptyString_Returns_0()
        {
            const int expected = 0;

            int result = StringCalculator.StringCalculator.Add("");

            Assert.AreEqual(expected, result);
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]
        [TestCase("99", 99)]

        public void Add_PassingSingleNumber_ReturnsNumber(string input, int expected)
        {
            int result = StringCalculator.StringCalculator.Add(input);

            Assert.AreEqual(expected, result);
        }

        [TestCase("1,1", 2)]
        [TestCase("1,1,1", 3)]
        [TestCase("1,1,1,1,1,1,1", 7)]

        public void Add_PassingMultipleNumbers_ReturnsSum(string input, int expected)
        {
            int result = StringCalculator.StringCalculator.Add(input);

            Assert.AreEqual(expected, result);
        }
    }
}