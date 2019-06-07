using NUnit.Framework;
using RomanNumeral;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void With_1_returns_I()
        {
            Transform convert = new Transform();
            int number = 1;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("I", ans);
        }

        [Test]
        public void With_2_returns_II()
        {
            Transform convert = new Transform();
            int number = 2;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("II", ans);
        }

        [Test]
        public void With_4_returns_IV()
        {
            Transform convert = new Transform();
            int number = 4;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("IV", ans);
        }

        [Test]
        public void With_5_returns_V()
        {
            Transform convert = new Transform();
            int number = 5;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("V", ans);
        }

        [Test]
        public void With_7_returns_VII()
        {
            Transform convert = new Transform();
            int number = 7;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("VII", ans);
        }

        [Test]
        public void With_9_returns_IX()
        {
            Transform convert = new Transform();
            int number = 9;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("IX", ans);
        }

        [Test]
        public void With_10_returns_X()
        {
            Transform convert = new Transform();
            int number = 10;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("X", ans);
        }

        [Test]
        public void With_12_returns_XII()
        {
            Transform convert = new Transform();
            int number = 12;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XII", ans);
        }

        [Test]
        public void With_14_returns_XIV()
        {
            Transform convert = new Transform();
            int number = 14;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XIV", ans);
        }

        [Test]
        public void With_18_returns_XVIII()
        {
            Transform convert = new Transform();
            int number = 18;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XVIII", ans);
        }

        [Test]
        public void With_19_returns_XIX()
        {
            Transform convert = new Transform();
            int number = 19;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XIX", ans);
        }

        [Test]
        public void With_20_returns_XX()
        {
            Transform convert = new Transform();
            int number = 20;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XX", ans);
        }

        [Test]
        public void With_27_returns_XXVII()
        {
            Transform convert = new Transform();
            int number = 27;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XXVII", ans);
        }

        [Test]
        public void With_30_returns_XXX()
        {
            Transform convert = new Transform();
            int number = 30;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XXX", ans);
        }

        [Test]
        public void With_39_returns_XXXIX()
        {
            Transform convert = new Transform();
            int number = 39;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XXXIX", ans);
        }

        [Test]
        public void With_40_returns_XL()
        {
            Transform convert = new Transform();
            int number = 40;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XL", ans);
        }

        [Test]
        public void With_42_returns_XLII()
        {
            Transform convert = new Transform();
            int number = 42;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XLII", ans);
        }

        [Test]
        public void With_46_returns_XLVI()
        {
            Transform convert = new Transform();
            int number = 46;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XLVI", ans);
        }

        [Test]
        public void With_49_returns_XLIX()
        {
            Transform convert = new Transform();
            int number = 49;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("XLIX", ans);
        }

        [Test]
        public void With_50_returns_L()
        {
            Transform convert = new Transform();
            int number = 50;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("L", ans);
        }

        [Test]
        public void With_60_returns_LX()
        {
            Transform convert = new Transform();
            int number = 60;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("LX", ans);
        }

        [Test]
        public void With_68_returns_LXVIII()
        {
            Transform convert = new Transform();
            int number = 68;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("LXVIII", ans);
        }

        [Test]
        public void With_84_returns_LXXXIV()
        {
            Transform convert = new Transform();
            int number = 84;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("LXXXIV", ans);
        }

        [Test]
        public void With_89_returns_LXXXIX()
        {
            Transform convert = new Transform();
            int number = 89;
            string ans = convert.ToRoman(number);
            Assert.AreEqual("LXXXIX", ans);
        }

    }
}