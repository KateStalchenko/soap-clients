using System.ServiceModel;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient.DataContracts.DeleteProduct
{
    [MessageContract(IsWrapped = false)]
    public class DeleteProductRequest
    {
        [MessageBodyMember(Name = "DeleteProduct")]
        public DeleteProductRequestBody DeleteProductRequestBody { get; set; }

        public DeleteProductRequest(DeleteProductRequestBody body)
        {
            DeleteProductRequestBody = body;
        }

        public static DeleteProductRequest CreateNew(Product product) =>
            new DeleteProductRequest(new DeleteProductRequestBody(product));
    }
}