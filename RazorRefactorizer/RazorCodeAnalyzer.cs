using Microsoft.CodeAnalysis.Text;

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RazorRefactorizer
{
    public class RazorCodeAnalyzer
    {
        public List<RazorCodeSelection> AnalyzeRazorCode(string razorCode)
        {
            var razorCodeSelections = new List<RazorCodeSelection>();

            // Finding all the sections of markup within Razor component
            var matches = Regex.Matches(razorCode, @"<[^>]+>([^<]*)</[^>]+>");

            foreach (Match match in matches)
            {
                var textSpan = new TextSpan(match.Index, match.Length);
                var selectedCode = match.Value;
                razorCodeSelections.Add(new RazorCodeSelection
                {
                    Span = textSpan,
                    SelectedCode = selectedCode
                });
            }

            return razorCodeSelections;
        }
    }
}
