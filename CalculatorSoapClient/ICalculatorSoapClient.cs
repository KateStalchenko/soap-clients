using System.ServiceModel;
using System.Threading.Tasks;

namespace CalculatorSoapClient
{
    [ServiceContract]
    interface ICalculatorSoapClient
    {
        [OperationContract(Action = "http://tempuri.org/Add", ReplyAction = "*")]
        Task<int> AddAsync(int intA, int intB);
        [OperationContract(Action = "http://tempuri.org/Subtract", ReplyAction = "*")]
        Task<int> Subtract(int intA, int intB);
        [OperationContract(Action = "http://tempuri.org/Multiply", ReplyAction = "*")]
        Task<int> Multiply(int intA, int intB);
        [OperationContract(Action = "http://tempuri.org/Divide", ReplyAction = "*")]
        Task<int> Divide(int intA, int intB);
    }
}
