namespace decorator_pattern.CoffeTypes
{
    public class DarkRoast : Beverage
    {

        public DarkRoast()
        {
            Description = "Dark Roast Coffe";
        }

        private string description;
        public override string Description { get => GetSize() + " " + description; set => description = value; }

        public override double Cost()
        {
            switch(GetSize())
            {
                case Size.TALL:
                    return .29;
                case Size.GRANDE:
                    return .30;
                case Size.VENTI:
                    return .35;
                default:
                    return .29;
            }
        }
    }
}
