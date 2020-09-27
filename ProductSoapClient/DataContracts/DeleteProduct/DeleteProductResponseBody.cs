using System.Runtime.Serialization;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient.DataContracts.DeleteProduct
{
    [DataContract(Namespace = Constants.DefaultNamespace)]
    public class DeleteProductResponseBody
    {
        [DataMember(EmitDefaultValue = false)]
        public ResponseResult DeleteProductResult { get; set; }
    }
}