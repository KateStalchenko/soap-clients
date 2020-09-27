using System.ServiceModel;
using System.Threading.Tasks;
using ProductSoapClient.DataContracts.AddProduct;
using ProductSoapClient.DataContracts.DeleteProduct;
using ProductSoapClient.DataContracts.GetProduct;
using ProductSoapClient.DataContracts.UpdateProduct;

namespace ProductSoapClient
{
    [ServiceContract]
    public interface IProductClient
    {
        [OperationContract(Action = "http://tempuri.org/AddProduct", ReplyAction = "*")]
        Task<AddProductResponse> AddProductAsync(AddProductRequest product);


        [OperationContract(Action = "http://tempuri.org/GetProduct", ReplyAction = "*")]
        Task<GetProductResponse> GetProductAsync(GetProductRequest getProductRequest);


        [OperationContract(Action = "http://tempuri.org/UpdateProduct", ReplyAction = "*")]
        Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest updateProductRequest);


        [OperationContract(Action = "http://tempuri.org/DeleteProduct", ReplyAction = "*")]
        Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest deleteProductRequest);
    }
}