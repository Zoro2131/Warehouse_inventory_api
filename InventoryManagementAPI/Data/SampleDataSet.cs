using System.Security.Cryptography.X509Certificates;

namespace InventoryManagementAPI.Data
{
    public class SampleDataSet
    {
        public static List<Models.ProductDefinition> GetSampleProducts()
        {
            return new List<Models.ProductDefinition>
            {
                new Models.ProductDefinition
                {
                    Id = 1,
                    Name = "Steel Beam",
                    IsFerrous = true,
                    Grade = "A36",
                    Length = 20.0,
                    Height = 0.5,
                    Width = 0.5,
                    Weight = 500.0
                },

                new Models.ProductDefinition
                {
                    Id = 2,
                    Name = "Aluminum Sheet",
                    IsFerrous = false,
                    Grade = "6061",
                    Length = 10.0,
                    Height = 0.1,
                    Width = 5.0,
                    Weight = 50.0
                },
                new Models.ProductDefinition
                {
                    Id = 3,
                    Name = "Copper Wire",
                    IsFerrous = false,
                    Grade = "C11000",
                    Length = 100.0,
                    Height = 0.01,
                    Width = 0.01,
                    Weight = 10.0
                }
            };
        }
    }
}
