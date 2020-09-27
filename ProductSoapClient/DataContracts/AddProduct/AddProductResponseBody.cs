using System.Runtime.Serialization;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient.DataContracts.AddProduct
{
    [DataContract(Namespace = Constants.DefaultNamespace)]
    public class AddProductResponseBody
    {
        [DataMember(EmitDefaultValue = false)]
        public ResponseResult AddProductResult { get; set; }
    }
}