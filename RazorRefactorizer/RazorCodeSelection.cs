using Microsoft.CodeAnalysis.Text;

namespace RazorRefactorizer
{
    public class RazorCodeSelection
    {
        public TextSpan Span { get; set; }
        public string SelectedCode { get; set; }
    }
}
