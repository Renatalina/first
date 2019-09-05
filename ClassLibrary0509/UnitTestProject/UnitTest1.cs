using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary0509;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Subtract_20_and_10_10returned()
        {
            //1.настройки тестовых данных
            //2.действия по проверке - тестированию
            //3.сравнить результат
            //1
            int a = 20;
            int b = 10;
            int expected = 10;
            //2
            MathHelper helper = new MathHelper();
            int result = helper.Subtract(a, b);
            //3
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Add_20_and_10_40expected_30returned_test_fail()
        {
            MathHelper helper = new MathHelper();
            int result = helper.Add(20, 10);
            Assert.AreEqual(40, result);
        }
    }
}
