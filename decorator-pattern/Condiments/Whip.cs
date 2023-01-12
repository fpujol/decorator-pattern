namespace decorator_pattern.Condiments
{
    public class Whip : CondimentDecorator
    {

        public Whip(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        
        public override string Description { get => Beverage.Description + ", Whip"; set => throw new NotImplementedException(); }

        public override double Cost()
        {
            switch (GetSize())
            {
                case Size.TALL:
                    return Beverage.Cost() + .25 + .59;
                case Size.GRANDE:
                    return Beverage.Cost() + .25 + .60;
                case Size.VENTI:
                    return Beverage.Cost() + .25 + .79;
                default:
                    return Beverage.Cost() + .25 + .59;
            }
        }

    }
}
