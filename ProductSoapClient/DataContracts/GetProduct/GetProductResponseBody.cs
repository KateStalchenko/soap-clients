using System.Runtime.Serialization;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient.DataContracts.GetProduct
{
    [DataContract(Namespace = Constants.DefaultNamespace)]
    public class GetProductResponseBody
    {
        [DataMember(Name = "GetProductResult", EmitDefaultValue = false)]
        public Product GetProductResult { get; set; }
    }
}