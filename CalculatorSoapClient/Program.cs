using System.Threading.Tasks;

namespace CalculatorSoapClient
{
    class Program
    {
        public static async Task Main()
        {
            var calculatorClient = new CalculatorSoapClient("http://www.dneonline.com/calculator.asmx");
            var result = await calculatorClient.AddAsync(25, 96);
        }
    }
}
