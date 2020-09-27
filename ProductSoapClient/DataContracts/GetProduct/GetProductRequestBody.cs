using System.Runtime.Serialization;

namespace ProductSoapClient.DataContracts.GetProduct
{
    [DataContract(Namespace = Constants.DefaultNamespace)]
    public class GetProductRequestBody
    {
        [DataMember(Name = "ProductID")]
        public int ProductId { get; set; }

        public GetProductRequestBody(int productId)
        {
            ProductId = productId;
        }
    }
}