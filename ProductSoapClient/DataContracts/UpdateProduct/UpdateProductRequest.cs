using System.ServiceModel;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient.DataContracts.UpdateProduct
{
    [MessageContract(IsWrapped = false)]
    public class UpdateProductRequest
    {
        [MessageBodyMember(Name = "UpdateProduct", Namespace = Constants.DefaultNamespace)]
        public UpdateProductRequestBody UpdateProductRequestBody { get; set; }

        public UpdateProductRequest(UpdateProductRequestBody body)
        {
            UpdateProductRequestBody = body;
        }

        public static UpdateProductRequest CreateNew(Product product) =>
            new UpdateProductRequest(new UpdateProductRequestBody(product));
    }
}