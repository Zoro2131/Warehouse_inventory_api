using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace InventoryManagementAPI.Models
{
    public class ProductDefinition
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        //This means it is magenetic
        public bool IsFerrous { get; set;}
        //The grade of the product
        public string Grade { get; set; } = string.Empty;
        //Will set the Wieght, Hight, and length of the product
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
    }
}
