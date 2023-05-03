using net_calculator_tester;

namespace NetCalculatorTester.Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();
            float num1 = 2.5f;
            float num2 = 3.7f;
            float expectedResult = 6.2f;

            float actualResult = calculator.Add(num1, num2);

            Assert.AreEqual(expectedResult, actualResult, $"La somma di {num1} e {num2} è {expectedResult} come previsto.");
        }

        [Test]
        public void TestSubtract()
        {
            Calculator calculator = new Calculator();
            float num1 = 7.2f;
            float num2 = 3.5f;
            float expectedResult = 3.7f;

            float actualResult = calculator.Subtract(num1, num2);

            Assert.That(actualResult, Is.EqualTo(expectedResult).Within(0.0001f), $"La sottrazione di {num2} da {num1} è {expectedResult} come previsto.");
        }

        [Test]
        public void TestDivide()
        {
            Calculator calculator = new Calculator();
            float num1 = 10.0f;
            float num2 = 5.0f;
            float expectedResult = 2.0f;

            float actualResult = calculator.Divide(num1, num2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestDivideByZero()
        {
            Calculator calculator = new Calculator();
            float num1 = 10.0f;
            float num2 = 0.0f;

            Assert.Throws<DivideByZeroException>(() => calculator.Divide(num1, num2));
        }

        [Test]
        public void TestMultiply()
        {
            Calculator calculator = new Calculator();
            float num1 = 2.5f;
            float num2 = 3.0f;
            float expectedResult = 7.5f;

            float actualResult = calculator.Multiply(num1, num2);

            Assert.AreEqual(expectedResult, actualResult, $"Successfully multiplied {num1} by {num2}. Result: {actualResult}");
        }

        [Test]
        public void TestMultiplyByZeroNum1()
        {
            Calculator calculator = new Calculator();
            float num1 = 0.0f;
            float num2 = 5.2f;
            float expectedResult = 0.0f;

            float actualResult = calculator.Multiply(num1, num2);

            Assert.AreEqual(expectedResult, actualResult, $"Moltiplicazione tra {num1} e {num2} avvenuta con successo. Il risultato è {actualResult} come previsto.");
        }

        [Test]
        public void TestMultiplyByZeroNum2()
        {
            Calculator calculator = new Calculator();
            float num1 = 5.2f;
            float num2 = 0.0f;
            float expectedResult = 0.0f;

            float actualResult = calculator.Multiply(num1, num2);

            Assert.AreEqual(expectedResult, actualResult, $"Moltiplicazione tra {num1} e {num2} avvenuta con successo. Il risultato è {actualResult} come previsto.");
        }

        [Test]
        public void TestMultiplyByZeroBoth()
        {
            Calculator calculator = new Calculator();
            float num1 = 0.0f;
            float num2 = 0.0f;
            float expectedResult = 0.0f;

            float actualResult = calculator.Multiply(num1, num2);

            Assert.AreEqual(expectedResult, actualResult, $"Moltiplicazione tra {num1} e {num2} avvenuta con successo. Il risultato è {actualResult} come previsto.");
        }
    }
}