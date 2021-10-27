using System;

namespace IntermidiateCSharp
{
    partial class Program
    {
        public class Text : PresentationObject
        {
            public int FontSize { get; set; }
            public string FontName { get; set; }

            public void HyperLinkToUrl(string url)
            {
                Console.WriteLine("The text has a hyperlink: " + url);
            }
        }
    }
}
