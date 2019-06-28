using NUnit.Framework;
using WordWrapDay1;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void WithAnNullString_AndOne_ReturnsNullString()
        {
            Wrapper wrap = new Wrapper();
            string test = "";

            string result = wrap.Wrap(test,1);

            string expected = "";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void WithTest_andFive_ReturnsTest()
        {
            Wrapper wrap = new Wrapper();
            string test = "test";

            string result = wrap.Wrap(test, 5);

            string expected = "test";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void WithTest_andThree_ReturnsTes_t()
        {
            Wrapper wrap = new Wrapper();
            string test = "test";

            string result = wrap.Wrap(test, 3);

            string expected = "tes\nt";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void WithTest_andOne_ReturnsT_e_s_t()
        {
            Wrapper wrap = new Wrapper();
            string test = "test";

            string result = wrap.Wrap(test, 1);

            string expected = "t\ne\ns\nt";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void With2EmptySpaces_andOne_ReturnsSpace_Space()
        {
            Wrapper wrap = new Wrapper();
            string test = "  ";

            string result = wrap.Wrap(test, 1);

            string expected = " \n ";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void WithILoveSchool_andThree_ReturnsExpected()
        {
            Wrapper wrap = new Wrapper();
            string test = "I love school";

            string result = wrap.Wrap(test, 3);

            string expected = "I l\nove\n sc\nhoo\nl";

            Assert.AreEqual(expected, result);
        }
    }
}