public class Item: FullAuditModel
{

public string Name { get; set; }
 public int Quantity { get; set; }
 public string Description { get; set; }
 public decimal? PurchasePrice { get; set; }

}