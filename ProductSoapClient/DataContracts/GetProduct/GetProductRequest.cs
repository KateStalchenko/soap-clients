using System.ServiceModel;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient.DataContracts.GetProduct
{
    [MessageContract(IsWrapped = false)]
    public class GetProductRequest
    {
        [MessageBodyMember(Name = "GetProduct", Namespace = Constants.DefaultNamespace)]
        public GetProductRequestBody GetProductRequestBody { get; set; }

        public GetProductRequest(GetProductRequestBody getProductRequestBody)
        {
            GetProductRequestBody = getProductRequestBody;
        }

        public static GetProductRequest CreateNew(int productId) =>
            new GetProductRequest(new GetProductRequestBody(productId));
    }
}