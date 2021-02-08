using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace HiXUnit
{
    public class DictionaryTest
    {
        private ITestOutputHelper OutputHelper { get; }

        public DictionaryTest(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
        }

        [Fact]
        public void AMethod()
        {
            OutputHelper.WriteLine("this is xunit - OutputHelper");

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("1", 1);
            dictionary.Add("2", 2);
            dictionary.Add("3", 4);
            dictionary.Add("a", "a");
            dictionary.Add("b", "b");
            //dictionary.Add("b", "c");
            dictionary.Add("aa", 'a');
            dictionary.Add("bb", 'b');
            dictionary.Add("cc", 'b');

            foreach (KeyValuePair<string, object> entry in dictionary)
            {
                OutputHelper.WriteLine("entry.key={0}, entry.key={0}, ", entry.Key, entry.Value);
            }

            Assert.True(true);
        }
    }
}
