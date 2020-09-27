using System.ServiceModel;

namespace ProductSoapClient.DataContracts.UpdateProduct
{
    [MessageContract(IsWrapped = false)]
    public class UpdateProductResponse
    {
        [MessageBodyMember(Name = "UpdateProductResponse", Namespace = Constants.DefaultNamespace)]
        public UpdateProductResponseBody UpdateProductResponseBody { get; set; }
    }
}