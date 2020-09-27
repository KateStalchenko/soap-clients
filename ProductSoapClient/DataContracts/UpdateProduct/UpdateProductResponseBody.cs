using System.Runtime.Serialization;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient.DataContracts.UpdateProduct
{
    [DataContract(Namespace = Constants.DefaultNamespace)]
    public class UpdateProductResponseBody
    {
        [DataMember(EmitDefaultValue = false)]
        public ResponseResult UpdateProductResult { get; set; }
    }
}