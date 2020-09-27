using System.ServiceModel;

namespace ProductSoapClient.DataContracts.GetProduct
{
    [MessageContract(IsWrapped = false)]
    public class GetProductResponse
    {
        [MessageBodyMember(Name = "GetProductResponse", Namespace = Constants.DefaultNamespace)]
        public GetProductResponseBody GetProductResponseBody { get; set; }
    }
}