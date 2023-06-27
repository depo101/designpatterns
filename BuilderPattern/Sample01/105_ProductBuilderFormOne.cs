namespace BuilderPattern.Sample01;

public class ProductBuilderFormOne : IProductBuilder
{
    public ProductBuilderFormOne()
    {
        _product = new Product();
    }
    protected override void MakeStepOne()
    {
        _product.BrandName = "Crazy things";
    }

    protected override void MakeStepTwo()
    {
        _product.Model = "for babies";
    }

    protected override void MakeStepThree()
    {
        _product.YearManufactured = new DateOnly(2023, 6, 27);
    }

    protected override void MakeStepFour()
    {
        _product.YearValidUntil = new DateOnly(2024, 12, 31);
    }
}