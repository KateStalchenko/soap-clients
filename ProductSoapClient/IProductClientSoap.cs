using System.Threading.Tasks;
using ProductSoapClient.DataContracts.AddProduct;
using ProductSoapClient.DataContracts.Common;
using ProductSoapClient.DataContracts.DeleteProduct;
using ProductSoapClient.DataContracts.GetProduct;
using ProductSoapClient.DataContracts.UpdateProduct;

namespace ProductSoapClient
{
    internal interface IProductClientSoap
    {
        Task<AddProductResponse> AddProductAsync(Product product);
        Task<GetProductResponse> GetProductAsync(int productId);
        Task<UpdateProductResponse> UpdateProductAsync(Product product);
        Task<DeleteProductResponse> DeleteProductAsync(Product product);
    }
}