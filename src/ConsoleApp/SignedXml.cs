
using System.Collections.Generic;

namespace ConsoleApp
{
    public class SignedXml
    {

        /*
           this.options = options || {};
  this.idMode = idMode
  this.references = []
  this.id = 0
  this.signingKey = null
  this.signatureAlgorithm = this.options.signatureAlgorithm || "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
  this.keyInfoProvider = null
  this.canonicalizationAlgorithm = "http://www.w3.org/2001/10/xml-exc-c14n#"
  this.signedXml = ""
  this.signatureXml = ""
  this.signatureNode = null
  this.signatureValue = ""
  this.originalXmlWithIds = ""
  this.validationErrors = []
  this.keyInfo = null
  this.idAttributes = [ 'Id', 'ID', 'id' ];
         
         
         */


        public dynamic Options { get; set; }
        public string IdMode { get; set; }

        public IEnumerable<string> References { get; } = new List<string>();

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












    }
}