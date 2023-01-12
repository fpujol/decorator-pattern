namespace decorator_pattern.CoffeTypes
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description="Espresso";
        }

        private string description;
        public override string Description { get => GetSize() + " " + description; set => description=value; }

        public override double Cost()
        {
            switch (GetSize())
            {
                case Size.TALL:
                    return .59;
                case Size.GRANDE:
                    return .60;
                case Size.VENTI:
                    return .79;
                default:
                    return .59;
            }
        }
        
    }
}
