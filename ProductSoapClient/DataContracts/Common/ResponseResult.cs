using System.Runtime.Serialization;

namespace ProductSoapClient.DataContracts.Common
{
    [DataContract(Name = "ResponseResult", Namespace = Constants.DefaultNamespace)]
    public class ResponseResult
    {
        [DataMember(Name = "ID", IsRequired = true)]
        public int Id { get; set; }
        [DataMember(Name = "ResultMessage")]
        public string ResultMessage { get; set; }
        [DataMember(Name = "Result", IsRequired = true, Order = 2)]
        public bool? Result { get; set; }
    }
}