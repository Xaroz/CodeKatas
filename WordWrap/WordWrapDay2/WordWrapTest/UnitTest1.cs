using NUnit.Framework;
using WordWrapDay2;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void WithEmptyStringAnd1_ReturnsEmptyString()
        {
            Wrapper wrap = new Wrapper();
            string test = "";
            string result = wrap.Wrap(test,1);

            string expected = "";

            Assert.AreEqual(expected, result);            
        }

        [Test]
        public void WithPeopleAndTwo_ReturnsExpected()
        {
            Wrapper wrap = new Wrapper();
            string test = "people";
            string result = wrap.Wrap(test, 2);

            string expected = "pe\nop\nle";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void WithPor_Favor_Paseme_en_A_AndFour_ReturnsExpected()
        {
            Wrapper wrap = new Wrapper();
            string test = "Por favor paseme en A";
            string result = wrap.Wrap(test, 4);

            string expected = "Por\nfavo\nr pa\nseme\nen A";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Withaaa_aAndTwo_ReturnsExpected()
        {
            Wrapper wrap = new Wrapper();
            string test = "aaa a";
            string result = wrap.Wrap(test, 2);

            string expected = "aa\na\na";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Withaaa_aAndOne_ReturnsExpected()
        {
            Wrapper wrap = new Wrapper();
            string test = "aaa a";
            string result = wrap.Wrap(test, 1);

            string expected = "a\na\na\na";

            Assert.AreEqual(expected, result);
        }
    }
}