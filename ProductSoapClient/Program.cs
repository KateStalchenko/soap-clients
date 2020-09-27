using System.Threading.Tasks;
using ProductSoapClient.Configuration;
using ProductSoapClient.DataContracts.Common;

namespace ProductSoapClient
{
    internal class Program
    {
        private static async Task Main()
        {
            var client = CreateClient();

            var customProduct = new Product("TestProduct", 25.36, "15");

            var result = await client.AddProductAsync(customProduct);

            customProduct.ProductId = result.AddProductResponseBody.AddProductResult.Id;
            customProduct.ListPrice = 100;

            await client.UpdateProductAsync(customProduct);

            var updatedProduct = await client.GetProductAsync(customProduct.ProductId);
            var deleteProductResponse = await client.DeleteProductAsync(customProduct);
        }

        private static IProductClientSoap CreateClient()
        {
            var config = ConfigurationReader.Read();
            var client = new ProductClientSoap(config.WebServiceUri);
            return client;
        }
    }
}