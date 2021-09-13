using Xunit;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void SplitLine_Returns_All_Words()
        {
            IEnumerable<string> input = new List<string> {"All these words should be captured individually", "Also these ones"};
            IEnumerable<string> expected = new List<string> {"All", "these", "words", "should", "be", "captured", "individually", "Also", "these", "ones"};

            IEnumerable<string> result = RegExpr.SplitLine(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SplitLine_Returns_Words_With_Digits()
        {
            IEnumerable<string> input = new List<string> {"1aksa 25asd2 akb24"};
            IEnumerable<string> expected = new List<string> {"1aksa", "25asd2", "akb24"};

            IEnumerable<string> result = RegExpr.SplitLine(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Resolutions_Returns_Tuple()
        {
            var input = "1920x1080, 1024x768, 1280x960";
            IEnumerable<(int, int)> expected = new List<(int, int)> {(1920, 1080), (1024,768), (1280, 960)};
            
            IEnumerable<(int, int)> result = RegExpr.Resolution(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InnerText_Returns_All_Inner_Text()
        {
            var inputHTML = "<div> <p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p> </div>";
            var inputTag = "p";
            IEnumerable<string> expected = new List<string> {"The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."};

            IEnumerable<string> result = RegExpr.InnerText(inputHTML, inputTag);

            Assert.Equal(expected, result);
        }
    }
}
