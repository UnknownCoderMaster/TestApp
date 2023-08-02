namespace TestApp.Data.Models;

public class Product
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public DateTime DateAdded { get; set; } = DateTime.Now;
    public string AddedUser { get; set; }
}
