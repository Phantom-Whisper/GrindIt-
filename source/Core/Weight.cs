namespace Core
{
    public class Weight
    {
        public double Value { get; }

        public Weight(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Weight must be greater than zero.");
            Value = value;
        }
    }
}