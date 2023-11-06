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
        public void Test995()
        {
            int number1 = 995;
            double expectedResults = 331;

            double actualRezults = Class2.Divide(number1);

            Assert.AreEqual(expectedResults, actualRezults);

        }

        

        [Test]
        public void TestWednesday()
        {

            DateTime today = DateTime.Now;

            bool isTodayWednesday = IsTodayWednesday(today);

            Assert.IsTrue(isTodayWednesday);

        }
        public bool IsTodayWednesday(DateTime dateToCheck)
        {
            return dateToCheck.DayOfWeek == DayOfWeek.Wednesday;
        }


        [Test]
        public void TestTime()
        {
            DateTime currentTime = DateTime.Now;

            bool isNow13 = IsNow13(currentTime);

            Assert.IsTrue(isNow13);
        }
        public bool IsNow13 (DateTime TimeNow)
        {
            return TimeNow == DateTime.Now;
        }


    } 

}
