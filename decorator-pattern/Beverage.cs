namespace decorator_pattern
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI }
        
        Size sise = Size.TALL;

        public abstract string Description { get; set; }

        public Size GetSize() => this.sise;

        public void SetSize(Size size)
        {
            this.sise = size;
        }

        public abstract double Cost();
    }
}
