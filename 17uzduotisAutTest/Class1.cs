using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17uzduotisAutTest
{
    public class Class1
    {
        [Test]
        public void Test()
        {
            int number1 = 995;
            double expectedResults = 331;
            double actualRezults = Class2.Divide(number1);

            Assert.AreEqual(expectedResults, actualRezults);

        }
    }
}
