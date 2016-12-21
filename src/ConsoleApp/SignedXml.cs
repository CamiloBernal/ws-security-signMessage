using System.Collections.Generic;

namespace ConsoleApp
{
    public class SignedXml
    {
        public dynamic Options { get; set; }
        public string IdMode { get; set; }

        public IList<Reference> References { get; } = new List<Reference>();

        public string Id { get; set; }

        public string SigningKey { get; set; }

        public string SignatureAlgorithm => "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

        public string KeyInfoProvider { get; set; }

        public string CanonicalizationAlgorithm => "http://www.w3.org/2001/10/xml-exc-c14n#";

        public string SignatureXml { get; set; }

        public object SignatureNode { get; set; }

        public string SignatureValue { get; set; }

        public string OriginalXmlWithIds { get; set; }

        public object KeyInfo { get; set; }

        public IEnumerable<string> IdAttributes => new List<string> { "Id", "ID", "id" };

        public void AddReference(string xpath, IEnumerable<string> transforms = null, string digestAlgorithm = "", string uri = "", string digestValue = "", string inclusiveNamespacesPrefixList = "", bool isEmptyUri = true)
        {
            var reference = new Reference
            {
                Xpath = xpath,
                DigestAlgorithm = !string.IsNullOrEmpty(digestAlgorithm) ? digestAlgorithm : "http://www.w3.org/2000/09/xmldsig#sha1",
                Uri = uri,
                DigestValue = digestValue,
                InclusiveNamespacesPrefixList = inclusiveNamespacesPrefixList,
                IsEmptyUri = isEmptyUri
            };

            if (transforms != null)
            {
                reference.Transforms.AddRange(transforms);
            }
            else
            {
                reference.Transforms.Add("http://www.w3.org/2001/10/xml-exc-c14n#");
            }

            References.Add(reference);
        }
    }
}