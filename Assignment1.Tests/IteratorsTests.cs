using Xunit;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
       
        [Fact]
        public void Flatten_Returns_Single_Stream()
        {
            IEnumerable<IEnumerable<string>> inputList = new List<List<string>> {new List<string> {"a","b","c"}, new List<string> {"d", "e", "f"}};
            IEnumerable<string> expectedList = new List<string> {"a", "b", "c", "d", "e", "f"};

            IEnumerable<string> resultList = Iterators.Flatten<string>(inputList);

            Assert.Equal(expectedList, resultList);
        }

        [Fact]
        public void Filter_Returns_All_Odds() 
        {
            IEnumerable<int> inputList = new List<int> {1,2,3,4,5,6,7,8,9};
            IEnumerable<int> expectedList = new List<int> {1,3,5,7,9};
            Predicate<int> odd = Iterators.Odd;

            IEnumerable<int> resultList = Iterators.Filter<int>(inputList, odd);

            Assert.Equal(expectedList, resultList);

        }
    }
}
