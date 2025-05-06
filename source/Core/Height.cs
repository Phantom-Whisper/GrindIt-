namespace Core
{
    public class Height
    {
        public double Value { get; }

        public Height(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Height must be greater than zero.");
            Value = value;
        }
    }
}