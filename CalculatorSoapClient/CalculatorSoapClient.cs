using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace CalculatorSoapClient
{
    class CalculatorSoapClient
    {
        private readonly ICalculatorSoapClient _serviceClient;

        public CalculatorSoapClient(string uri)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(uri));
            var chanelFactory = new ChannelFactory<ICalculatorSoapClient>(binding, endpoint);
            _serviceClient = chanelFactory.CreateChannel();
        }

        public Task<int> AddAsync(int intA, int intB)
        {
            return _serviceClient.AddAsync(intA, intB);
        }

        public Task<int> SubtractAsync(int intA, int intB)
        {
            return _serviceClient.Subtract(intA, intB);
        }

        public Task<int> MultiplyAsync(int intA, int intB)
        {
            return _serviceClient.Multiply(intA, intB);
        }

        public Task<int> DivideAsync(int intA, int intB)
        {
            return _serviceClient.Divide(intA, intB);
        }

    }
}
