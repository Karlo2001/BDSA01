using Xunit;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
       
        [Fact]
        public void Test1()
        {
            IEnumerable<IEnumerable<string>> inputList = new List<List<string>> {new List<string> {"a","b","c"}, new List<string> {"d", "e", "f"}};
            IEnumerable<string> expectedList = new List<string> {"a", "b", "c", "d", "e", "f"};

            IEnumerable<string> resultList = Iterators.Flatten<string>(inputList);

            Assert.Equal(expectedList, resultList);
        }
    }
}
