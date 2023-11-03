using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        //Addtions
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        //Subtraction
        [Test]
        public void Subtract_ValidTran()
        {
            Assert.AreEqual(3, Program.Subtract("9", "6"));
            Assert.AreEqual(212, Program.Subtract("333", "121"));
            Assert.AreEqual(1125, Program.Subtract("1132", "7"));
        }

        [Test]
        public void Subtract_InvalidTran()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "b"));
            Assert.Throws<FormatException>(() => Program.Subtract("b", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("b", "b"));
        }

        [Test]
        public void Subtract_NullTran()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        //Multiply
        [Test]
        public void Multiply_ValidTran()
        {
            Assert.AreEqual(10, Program.Multiply("5", "2"));
            Assert.AreEqual(30, Program.Multiply("10", "3"));
            Assert.AreEqual(48, Program.Multiply("6", "8"));
        }

        [Test]
        public void Multiply_InvalidTran()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "c"));
            Assert.Throws<FormatException>(() => Program.Multiply("c", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("c", "c"));
        }

        [Test]
        public void Multiply_NullTran()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        //Divide
        [Test]
        public void Divide_ValidTran()
        {
            Assert.AreEqual(1, Program.Divide("5", "5"));
            Assert.AreEqual(9, Program.Divide("72", "8"));
            Assert.AreEqual(12, Program.Divide("144", "12"));   
        }

        [Test]
        public void Divide_InvalidTran()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "c"));
            Assert.Throws<FormatException>(() => Program.Divide("c", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("c", "c"));
        }

        [Test]
        public void Divide_NullTran()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        //Power
        [Test]
        public void Power_ValidTran()
        {
            Assert.AreEqual(25, Program.Power("5", "2"));
            Assert.AreEqual(6, Program.Power("6", "1"));
            Assert.AreEqual(512, Program.Power("8", "3"));
            Assert.AreEqual(9, Program.Power("2", "3"));
        }

        [Test]
        public void Power_InvalidTran()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "c"));
            Assert.Throws<FormatException>(() => Program.Power("c", "1"));
            Assert.Throws<FormatException>(() => Program.Power("c", "c"));
        }

        [Test]
        public void Power_NullTran()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
