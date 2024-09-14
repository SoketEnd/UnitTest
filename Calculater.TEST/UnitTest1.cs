using TasckHome; // Обновленный неймспейс


namespace TasckHome.TEST
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test] 
        public void Additional_ReturnsCorrectSum()
        {
            var calculator = new Calculator();

            int a = 5;
            int b = 5;

            int result = calculator.Additional(a, b);

            // Проверяем, что результат равен 10
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Subtraction_ReturnsCorrectMinus()
        {
            var calculator = new Calculator(); 
            
            int a = 5;
            int b = 4;

            int res = calculator.Subtraction(a, b);
            Assert.AreEqual(1, res);
        }

        [Test]
        public void Multiplication_ReturnsCorrectMulty()
        {
            var calculator = new Calculator();
            int a = 5;
            int b = 4;

            int res = calculator.Multiplication(a, b);

            Assert.AreEqual(20, res);
        }

        [Test]
        public void Division_ReturnsCorrectDivis()
        {
            var calculator = new Calculator();
            int a = 20;
            int b = 0;

            Assert.Throws<DivideByZeroException>(() => calculator.Division(a, b));
        }
    }
}