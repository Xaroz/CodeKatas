using System;

namespace WordWrapDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Wrapper wrap = new Wrapper();
            string test = "aaa a";
            string result = wrap.Wrap(test, 2);
        }
    }
}
