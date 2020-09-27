using System.ServiceModel;

namespace ProductSoapClient.DataContracts.DeleteProduct
{
    [MessageContract(IsWrapped = false)]
    public class DeleteProductResponse
    {
        [MessageBodyMember(Name = "DeleteProductResponse", Namespace = Constants.DefaultNamespace)]
        public DeleteProductResponseBody DeleteProductResponseBody { get; set; }
    }
}