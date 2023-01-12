namespace decorator_pattern.CoffeTypes
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffe";
        }

        private string description;
        public override string Description { get => GetSize() + " " + description; set => description = value; }

        public override double Cost()
        {
            switch (GetSize())
            {
                case Size.TALL:
                    return .49;
                case Size.GRANDE:
                    return .50;
                case Size.VENTI:
                    return .69;
                default:
                    return .49;
            }
        }
    }
}
