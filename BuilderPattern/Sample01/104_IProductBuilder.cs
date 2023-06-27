namespace BuilderPattern.Sample01;

public abstract class IProductBuilder : IBuilder
{
    protected IProduct _product;
    public virtual IProduct Build()
    {
        MakeStepOne();
        MakeStepTwo();
        MakeStepThree();
        MakeStepFour();

        return _product;
    }
    protected abstract void MakeStepOne();
    protected abstract void MakeStepTwo();
    protected abstract void MakeStepThree();
    protected abstract void MakeStepFour();
}