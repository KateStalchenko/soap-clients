using System;
using System.Runtime.Serialization;

namespace ProductSoapClient.DataContracts.Common
{
    [DataContract(Name = "Product", Namespace = Constants.DefaultNamespace)]
    public class Product
    {
        [DataMember(Name = "ProductID", IsRequired = true)]
        public int ProductId { get; set; }


        [DataMember(Name = "Name", Order = 1)] 
        public string Name { get; set; }


        [DataMember(Name = "ProductNumber", Order = 2)]
        public string ProductNumber { get; set; }


        [DataMember(Name = "MakeFlag", Order = 3)]
        public bool? MakeFlag { get; set; }


        [DataMember(Name = "FinishedGoodsFlag", Order = 4)]
        public bool? FinishedGoodsFlag { get; set; }


        [DataMember(Name = "Color", Order = 5)]
        public string Color { get; set; }


        [DataMember(Name = "SafetyStockLevel", Order = 6)]
        public short? SafetyStockLevel { get; set; }


        [DataMember(Name = "ReorderPoint", Order = 7)]
        public short? ReorderPoint { get; set; }


        [DataMember(Name = "StandardCost", Order = 8)]
        public decimal? StandardCost { get; set; }


        [DataMember(Name = "ListPrice", Order = 9)]
        public double? ListPrice { get; set; }


        [DataMember(Name = "Size", Order = 10)]
        public string Size { get; set; }


        [DataMember(Name = "SizeUnitMeasureCode", Order = 11)]
        public string SizeUnitMeasureCode { get; set; }


        [DataMember(Name = "WeightUnitMeasureCode", Order = 12)]
        public string WeightUnitMeasureCode { get; set; }


        [DataMember(Name = "Weight", Order = 13)]
        public decimal? Weight { get; set; }


        [DataMember(Name = "DaysToManufacture", Order = 14)]
        public int? DaysToManufacture { get; set; }


        [DataMember(Name = "ProductLine", Order = 15)]
        public string ProductLine { get; set; }


        [DataMember(Name = "Class", Order = 16)]
        public string Class { get; set; }


        [DataMember(Name = "Style", Order = 17)]
        public string Style { get; set; }


        [DataMember(Name = "ProductSubcategoryID", Order = 18)]
        public int? ProductSubcategoryId { get; set; }


        [DataMember(Name = "ProductModelID", Order = 19)]
        public int? ProductModelId { get; set; }


        [DataMember(Name = "SellStartDate", Order = 20)]
        public DateTime? SellStartDate { get; set; }


        [DataMember(Name = "SellEndDate", Order = 21)]
        public DateTime? SellEndDate { get; set; }


        [DataMember(Name = "DiscontinuedDate", Order = 22)]
        public DateTime? DiscontinuedDate { get; set; }


        [DataMember(Name = "rowguid", Order = 23)]
        public Guid? Rowguid { get; set; }


        [DataMember(Name = "ModifiedDate", Order = 24)]
        public DateTime? ModifiedDate { get; set; }

        public Product(string productName, double listPrice, string productNumber)
        {
            Name = productName;
            ListPrice = listPrice;
            ProductNumber = productNumber;
        }
    }
}