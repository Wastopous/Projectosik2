namespace Projectosik2;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string description, decimal price, string category)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Category = category;
    }
}