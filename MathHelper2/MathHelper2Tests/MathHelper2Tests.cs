using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathHelper2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper2.Tests
{
    [TestClass()]
    public class MathHelper2Tests
    {
        [TestMethod()]
        public void SubtractTest()
        {
            //1.настройки тестовых данных
            //2.действия по проверке - тестированию
            //3.сравнить результат
            //1
            int a = 20;
            int b = 10;
            int expected = 10;
            //2
            MathHelper2 helper = new MathHelper2();
            int result = helper.Subtract(a, b);
            //3
            Assert.AreEqual(expected, result);
        }
    }
}