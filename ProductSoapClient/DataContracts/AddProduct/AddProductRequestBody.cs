using System.Runtime.Serialization;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient.DataContracts.AddProduct
{
    [DataContract(Namespace = Constants.DefaultNamespace)]
    public class AddProductRequestBody
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string ProductName;

        [DataMember(Order = 1)]
        public double ListPrice;

        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string ProductNumber;

        public AddProductRequestBody(Product product)
        {
            ProductName = product.Name;
            ListPrice = product.ListPrice.GetValueOrDefault();
            ProductNumber = product.ProductNumber;
        }
    }
}