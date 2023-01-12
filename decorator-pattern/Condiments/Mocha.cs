namespace decorator_pattern.Condiments
{
    public class Mocha : CondimentDecorator
    {

        public Mocha(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        
        public override string Description { get => Beverage.Description + ", Mocha"; set => throw new NotImplementedException(); }

        public override double Cost()
        {
            switch (GetSize())
            {
                case Size.TALL:
                    return Beverage.Cost() + .20 +.59;
                case Size.GRANDE:
                    return Beverage.Cost() + .20 + .60;
                case Size.VENTI:
                    return Beverage.Cost() + .20 + .79;
                default:
                    return Beverage.Cost() + .20 + .59;
            }

        }

    }
}
