using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            foreach (var word in lines)
            {
                var pattern = @"[a-zA-z0-9]+";
                Regex rgx = new Regex(pattern);

                foreach (Match match in rgx.Matches(word))
                {
                    yield return match.Value;
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            var pattern = @"(?<width>\d{3,5})x(?<height>\d{3,5})";
            Regex rgx = new Regex(pattern);

            foreach (Match match in rgx.Matches(resolutions))
            {

                int width = Int32.Parse(match.Groups[1].Value);
                int height = Int32.Parse(match.Groups[2].Value);

                yield return (width, height);
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            var pattern = @"<(" + tag + ")>(.+)<\\/\\1>";
            var replacePattern = @"(<[^>]+>)+";
            Regex rgx = new Regex(pattern);
            foreach (Match match in rgx.Matches(html))
            {
                Regex reg = new Regex(replacePattern);
                yield return reg.Replace(match.Groups[2].Value, @"");
            }
        }
    }
}
