namespace BuilderPattern.Sample01;

public class ProductManager
{
    public IProduct CreateProductBuilder(IProductBuilder builder)
    {
        return builder.Build();
    }
}