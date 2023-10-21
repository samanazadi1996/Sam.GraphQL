namespace Sam.GraphQL.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Barcode { get; set; }
    public DateTime InsertDateTime { get; set; }
    public int Count { get; set; }
}
