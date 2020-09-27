using System;
using System.ServiceModel;
using System.Threading.Tasks;
using ProductSoapClient.DataContracts.AddProduct;
using ProductSoapClient.DataContracts.Common;
using ProductSoapClient.DataContracts.DeleteProduct;
using ProductSoapClient.DataContracts.GetProduct;
using ProductSoapClient.DataContracts.UpdateProduct;

namespace ProductSoapClient
{
    internal class ProductClientSoap: IProductClientSoap
    {
        private readonly IProductClient _productClient;

        public ProductClientSoap(string uri)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(uri));
            var chanelFactory = new ChannelFactory<IProductClient>(binding, endpoint);
            _productClient = chanelFactory.CreateChannel();
        }

        public Task<AddProductResponse> AddProductAsync(Product product)
        {
            return _productClient.AddProductAsync(AddProductRequest.CreateNew(product));
        }

        public Task<GetProductResponse> GetProductAsync(int productId)
        {
            return _productClient.GetProductAsync(GetProductRequest.CreateNew(productId));
        }

        public Task<UpdateProductResponse> UpdateProductAsync(Product product)
        {
            return _productClient.UpdateProductAsync(UpdateProductRequest.CreateNew(product));
        }

        public Task<DeleteProductResponse> DeleteProductAsync(Product product)
        {
            return _productClient.DeleteProductAsync(DeleteProductRequest.CreateNew(product));
        }
    }
}