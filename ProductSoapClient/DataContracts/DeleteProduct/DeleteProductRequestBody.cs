using System.Runtime.Serialization;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient.DataContracts.DeleteProduct
{
    [DataContract(Namespace = Constants.DefaultNamespace)]
    public class DeleteProductRequestBody
    {
        [DataMember(Name = "ProductID")]
        public int ProductId { get; set; }

        public DeleteProductRequestBody(Product product)
        {
            ProductId = product.ProductId;
        }
    }
}