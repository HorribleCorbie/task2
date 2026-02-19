using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CountRatingTest()
        {
            string result = "Кол-во 5: 2\nКол-во 4: 1\nКол-во 3: 2\nКол-во 2: 0";
            string res2 = Logic.CountRating(new int[] {5,4,5,3,3 });
            Assert.AreEqual(result, res2);
        }
        [TestMethod()]
        public void CountRatingTest1()
        {
            string result = "Кол-во 5: 0\nКол-во 4: 0\nКол-во 3: 0\nКол-во 2: 0";
            string res2 = Logic.CountRating(new int[5]);
            Assert.Fail(result, res2);
        }
    }
}