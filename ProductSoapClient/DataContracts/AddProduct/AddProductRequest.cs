using System.ServiceModel;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient.DataContracts.AddProduct
{
    [MessageContract(IsWrapped = false)]
    public class AddProductRequest
    {
        [MessageBodyMember(Name = "AddProduct", Namespace = Constants.DefaultNamespace)]
        public AddProductRequestBody AddProductRequestBody;

        public AddProductRequest(AddProductRequestBody addProductRequestBody)
        {
            AddProductRequestBody = addProductRequestBody;
        }

        public static AddProductRequest CreateNew(Product product) =>
            new AddProductRequest(new AddProductRequestBody(product));
    }
}