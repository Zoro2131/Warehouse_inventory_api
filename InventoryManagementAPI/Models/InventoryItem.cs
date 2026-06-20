namespace InventoryManagementAPI.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public int ProductDefinitionId { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; } = string.Empty;
    }
}
