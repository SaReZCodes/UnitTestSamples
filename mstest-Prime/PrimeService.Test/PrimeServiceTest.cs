using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeService.Test
{
    [TestClass]
    public class PrimeServiceTest
    {

        PrimeService primeService;
        [TestInitialize]
        public void TestInitialize()
        {
            primeService = new PrimeService();
        }

        [TestMethod]
        public void IsPrimeOne()
        {
            var result = primeService.IsPrime(1);
            Assert.IsFalse(result, $"{1}  is not prime");
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrimeTwo(int value)
        {
            var result = primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} is not  prime");
        }

        [TestMethod]
        public void IsPrimeThree()
        {
            var result = primeService.IsPrime(2);
            Assert.IsTrue(result, $"{2}  is  prime");
        }
        [TestMethod]
        public void IsPrimeFour()
        {
            var result = primeService.IsPrime(3);
            Assert.IsTrue(result, $"{4}  is  prime");
        }

        [TestMethod]
        public void IsPrimeFive()
        {
            var result = primeService.IsPrime(4);
            Assert.IsFalse(result, $"{4}  is not prime");
        }

        [TestMethod]
        public void IsPrimeSix()
        {
            var result = primeService.IsPrime(5);
            Assert.IsTrue(result, $"{5} is   prime");
        }
        [DataTestMethod]

        [DataRow(7)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(17)]
        [DataRow(19)]
        public void IsPrimeSeven(int value)
        {
            var result = primeService.IsPrime(value);
            Assert.IsTrue(result, $"{value} is   prime");
        }

        [DataTestMethod]

        [DataRow(8)]
        [DataRow(10)]
        [DataRow(12)]
        [DataRow(14)]
        [DataRow(91)]
        public void IsPrimeEight(int value)
        {
            var result = primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} is not  prime");
        }
    }
}
