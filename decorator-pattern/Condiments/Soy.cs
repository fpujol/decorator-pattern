namespace decorator_pattern.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }
        
        public override string Description { get => Beverage.Description + ", Soy"; set => throw new NotImplementedException(); }

        public override double Cost()
        {
            switch (GetSize())
            {
                case Size.TALL:
                    return Beverage.Cost() + .35 + .59;
                case Size.GRANDE:
                    return Beverage.Cost() + .35 + .60;
                case Size.VENTI:
                    return Beverage.Cost() + .35 + .79;
                default:
                    return Beverage.Cost() + .35 + .59;
            }
            
        }

    }
}
