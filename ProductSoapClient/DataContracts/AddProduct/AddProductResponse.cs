using System.ServiceModel;

namespace ProductSoapClient.DataContracts.AddProduct
{
    [MessageContract(IsWrapped = false)]
    public class AddProductResponse
    {
        [MessageBodyMember(Name = "AddProductResponse", Namespace = Constants.DefaultNamespace)]
        public AddProductResponseBody AddProductResponseBody;
    }
}