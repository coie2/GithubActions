using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_ValidColeOie()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_InvalidColeOie()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_NullColeOie()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_ValidColeOie()
        {
            Assert.AreEqual(3, Program.Subtract("4", "1"));
            Assert.AreEqual(5, Program.Subtract("10", "5"));
            Assert.AreEqual(12, Program.Subtract("20", "8"));
        }

        [Test]
        public void Subtract_InvalidColeOie()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_NullColeOie()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_ValidColeOie()
        {
            Assert.AreEqual(3, Program.Multiply("3", "1"));
            Assert.AreEqual(5, Program.Multiply("1", "5"));
            Assert.AreEqual(12, Program.Multiply("6", "2"));
        }

        [Test]
        public void Multiply_InvalidColeOie()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_NullColeOie()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Divide_ValidColeOie()
        {
            Assert.AreEqual(3, Program.Divide("9", "3"));
            Assert.AreEqual(5, Program.Divide("10", "2"));
            Assert.AreEqual(12, Program.Divide("24", "2"));
        }

        [Test]
        public void Divide_InvalidColeOie()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_NullColeOie()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Power_ValidColeOie()
        {
            Assert.AreEqual(16, Program.Power("4", "2"));
            Assert.AreEqual(1000, Program.Power("10", "3"));
            Assert.AreEqual(16, Program.Power("2", "3"));
        }

        [Test]
        public void Power_InvalidColeOie()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_NullColeOie()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
