namespace BuilderPattern.Sample01;

public interface IProduct
{
    string BrandName { get; set; }
    string Model { get; set; }
    DateOnly YearManufactured { get; set; }
    DateOnly YearValidUntil { get; set; }
    public string Run();
}