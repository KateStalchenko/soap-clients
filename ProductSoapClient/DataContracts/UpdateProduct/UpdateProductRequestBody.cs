using System.Runtime.Serialization;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient.DataContracts.UpdateProduct
{
    [DataContract(Namespace = Constants.DefaultNamespace)]
    public class UpdateProductRequestBody
    {
        [DataMember(Name="ProductID")]
        public int ProductId { get; set; }


        [DataMember(Name = "ProductName")]
        public string ProductName { get; set; }


        [DataMember(Name = "ListPrice")]
        public double ListPrice { get; set; }


        [DataMember(Name = "ProductNumber")]
        public string ProductNumber { get; set; }

        public UpdateProductRequestBody(Product product)
        {
            ProductId = product.ProductId;
            ProductName = product.Name;
            ListPrice = product.ListPrice.GetValueOrDefault();
            ProductNumber = product.ProductNumber;
        }
    }
}