using System;

namespace Projectosik2;

public class Sale
{
    public int ID { get; set; }
    public DateTime Sale_Date { get; set; }
    public decimal Price { get; set; }
    public string Product { get; set; }
    public string Client { get; set; }

    public Sale(int id, DateTime sd, decimal price, string product, string client)
    {
        this.ID = id;
        this.Sale_Date = sd;
        this.Price = price;
        this.Product = product;
        this.Client = client;
    }
}