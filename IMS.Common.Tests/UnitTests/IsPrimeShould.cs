using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common.Library;


namespace IMS.Common.Tests.UnitTests
{
    [TestClass]
    public class IsPrimeShould
    {

        private PrimeService _PrimeService;
        
        [TestInitialize]
        public void Initialize()
        {
            _PrimeService = new PrimeService();
        }

        //[TestMethod]
        //[ExpectedException(typeof(System.NotImplementedException))]
        //public void ReturnFalseGivenValueOf1()
        //{
        //    var res = _PrimeService.IsPrime(1);
        //    Assert.IsFalse(res);
        //}

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            var res = _PrimeService.IsPrime(1);
            Assert.IsFalse(res);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            var result = _PrimeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }

    }
}
