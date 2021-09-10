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

        [Fact]
        public void Filter_Returns_All_Evens() 
        {
            IEnumerable<int> inputList = new List<int> {1,2,3,4,5,6,7,8,9};
            IEnumerable<int> expectedList = new List<int> {2,4,6,8};
            Predicate<int> even = Iterators.Even;

            IEnumerable<int> resultList = Iterators.Filter<int>(inputList, even);

            Assert.Equal(expectedList, resultList);

        }

        [Fact]
        public void Filter_Returns_Divisible_By_Four() 
        {
            IEnumerable<int> inputList = new List<int> {1,2,3,4,5,6,7,8,9};
            IEnumerable<int> expectedList = new List<int> {4,8};
            Predicate<int> four = Iterators.DivisibleByFour;

            IEnumerable<int> resultList = Iterators.Filter<int>(inputList, four);

            Assert.Equal(expectedList, resultList);

        }

        [Fact]
        public void Filter_Returns_Strings_With_Length_Three() 
        {
            IEnumerable<string> inputList = new List<string> {"str", "four","three","123"};
            IEnumerable<string> expectedList = new List<string> {"str","123"};
            Predicate<string> lengthEqualsThree = Iterators.LengthEqualsThree;

            IEnumerable<string> resultList = Iterators.Filter<string>(inputList, lengthEqualsThree);

            Assert.Equal(expectedList, resultList);

        }
    }
}
