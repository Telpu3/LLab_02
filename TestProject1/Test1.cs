using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using _2;  

namespace PerfectNumberTests
{
    [TestClass]
    public class PerfectNumberTests
    {
        // ========== ТЕСТЫ ДЛЯ ЗАДАЧИ 1 ==========

        [TestMethod]
        public void IsPerfect_ValidPerfectNumber_ReturnsTrue()
        {
            int number = 6;  // 6 = 1+2+3

            bool result = PerfectNumberLogic.IsPerfect(number);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPerfect_AnotherPerfectNumber_ReturnsTrue()
        {
            int number = 28; // 28 = 1+2+4+7+14
            bool result = PerfectNumberLogic.IsPerfect(number);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPerfect_NotPerfectNumber_ReturnsFalse()
        {
            int number = 10;
            bool result = PerfectNumberLogic.IsPerfect(number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPerfect_NumberLessThan2_ReturnsFalse()
        {
            Assert.IsFalse(PerfectNumberLogic.IsPerfect(1));
            Assert.IsFalse(PerfectNumberLogic.IsPerfect(0));
            Assert.IsFalse(PerfectNumberLogic.IsPerfect(-5));
        }

        // ========== ТЕСТЫ ДЛЯ ЗАДАЧИ 2 ==========

        [TestMethod]
        public void GetPerfectNumbersUpTo_UpTo10_ReturnsOnly6()
        {
            // Act
            var result = PerfectNumberLogic.GetPerfectNumbersUpTo(10);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(6, result[0].Number);
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, result[0].Divisors);
        }

        [TestMethod]
        public void GetPerfectNumbersUpTo_UpTo30_Returns6And28()
        {
            var result = PerfectNumberLogic.GetPerfectNumbersUpTo(30);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(6, result[0].Number);
            Assert.AreEqual(28, result[1].Number);
        }

        [TestMethod]
        public void GetPerfectNumbersUpTo_NoPerfectNumbers_ReturnsEmpty()
        {
            var result = PerfectNumberLogic.GetPerfectNumbersUpTo(5);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GetPerfectNumbersUpTo_NegativeInput_ReturnsEmpty()
        {
            var result = PerfectNumberLogic.GetPerfectNumbersUpTo(-10);
            Assert.AreEqual(0, result.Count);
        }

        // ========== ТЕСТЫ ДЛЯ ЗАДАЧИ 3 ==========

        [TestMethod]
        public void GetProperDivisors_For6_Returns1_2_3()
        {
            var divisors = PerfectNumberLogic.GetProperDivisors(6);
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, divisors);
        }

        [TestMethod]
        public void GetProperDivisors_For28_Returns1_2_4_7_14()
        {
            var divisors = PerfectNumberLogic.GetProperDivisors(28);
            CollectionAssert.AreEqual(new List<int> { 1, 2, 4, 7, 14 }, divisors);
        }

        [TestMethod]
        public void GetProperDivisors_ForPrimeNumber_ReturnsListWithOne()
        {
            var divisors = PerfectNumberLogic.GetProperDivisors(13);
            Assert.AreEqual(1, divisors.Count);  
            Assert.AreEqual(1, divisors[0]);     
        }

        [TestMethod]
        public void GetProperDivisors_For1_ReturnsEmptyList()
        {
            var divisors = PerfectNumberLogic.GetProperDivisors(1);
            Assert.AreEqual(0, divisors.Count);
        }

        [TestMethod]
        public void GetProperDivisors_SumEqualsNumber_ForPerfectNumber()
        {
            int num = 28;
            var divisors = PerfectNumberLogic.GetProperDivisors(num);
            int sum = divisors.Sum();
            Assert.AreEqual(num, sum);
        }
        [TestMethod]
        public void IsPerfect_Zero_ReturnsFalse()
        {
            Assert.IsFalse(PerfectNumberLogic.IsPerfect(0));
        }

        [TestMethod]
        public void IsPerfect_NegativeNumber_ReturnsFalse()
        {
            Assert.IsFalse(PerfectNumberLogic.IsPerfect(-6));
        }

        [TestMethod]
        public void IsPerfect_NumberOne_ReturnsFalse()
        {
            Assert.IsFalse(PerfectNumberLogic.IsPerfect(1));
        }

        [TestMethod]
        public void GetProperDivisors_ForNumber1_ReturnsEmpty()
        {
            var divisors = PerfectNumberLogic.GetProperDivisors(1);
            Assert.AreEqual(0, divisors.Count);
        }

        [TestMethod]
        public void GetProperDivisors_ForNumber2_ReturnsListWithOne()
        {
            var divisors = PerfectNumberLogic.GetProperDivisors(2);
            Assert.AreEqual(1, divisors.Count);
            Assert.AreEqual(1, divisors[0]);
        }

        [TestMethod]
        public void GetProperDivisors_ForPerfectNumber496_SumEqualsNumber()
        {
            int num = 496;  // 496 = 1+2+4+8+16+31+62+124+248
            var divisors = PerfectNumberLogic.GetProperDivisors(num);
            int sum = divisors.Sum();
            Assert.AreEqual(num, sum);
        }

        [TestMethod]
        public void GetPerfectNumbersUpTo_LargeRange_Contains496()
        {
            var result = PerfectNumberLogic.GetPerfectNumbersUpTo(500);
            Assert.IsTrue(result.Any(x => x.Number == 496));
        }

        [TestMethod]
        public void GetPerfectNumbersUpTo_UpTo10000_Contains8128()
        {
            var result = PerfectNumberLogic.GetPerfectNumbersUpTo(10000);
            Assert.IsTrue(result.Any(x => x.Number == 8128));
        }

        [TestMethod]
        public void IsPerfect_NextPerfectNumber33550336_ReturnsTrue()
        {        
            Assert.IsTrue(PerfectNumberLogic.IsPerfect(33550336));
        }

        [TestMethod]
        public void GetProperDivisors_ForLargeNumber_DoesNotHang()
        {
            var divisors = PerfectNumberLogic.GetProperDivisors(1000000);
            Assert.IsNotNull(divisors);
        }
    }
}