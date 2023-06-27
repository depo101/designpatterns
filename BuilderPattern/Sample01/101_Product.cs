using System.Text;

namespace BuilderPattern.Sample01;

public class Product : IProduct
{
    public string BrandName { get; set; }
    public string Model { get; set; }
    public DateOnly YearManufactured { get; set; }
    public DateOnly YearValidUntil { get; set; }

    public Product()
    {
        
    }
    public Product(string brandName, string model, DateOnly yearManufactured, DateOnly yearValidUntil)
    {
        BrandName = brandName;
        Model = model;
        YearManufactured = yearManufactured;
        YearManufactured = yearValidUntil;
    }

    public Product(string brandName, string model)
    {
        BrandName = brandName;
        Model = model;
        YearManufactured = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        YearValidUntil = new DateOnly(DateTime.Today.AddYears(1).Year, DateTime.Today.Month, DateTime.Today.Day);
    }

    public string Run()
    {
        StringBuilder sb = new();
        sb.AppendLine("Brand name : " + this.BrandName);
        sb.AppendLine("Model : " + this.Model);
        sb.AppendLine("Manufactured year : " + this.YearManufactured);
        sb.AppendLine("Valid until year : " + this.YearValidUntil);
        return sb.ToString();
    }
}