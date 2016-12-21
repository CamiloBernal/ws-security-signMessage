using System.Collections.Generic;

namespace ConsoleApp
{
    public class Reference
    {
        public string Xpath { get; set; }
        public List<string> Transforms { get;  } = new List<string>();
        public string DigestAlgorithm { get; set; }
        public string Uri { get; set; }
        public string DigestValue { get; set; }
        public string InclusiveNamespacesPrefixList { get; set; }
        public bool IsEmptyUri { get; set; }
    }
}