namespace GrindIt.NutritionLib
{
    public class Water
    {
        private int waterTarget;
        public int WaterTarget
        {
            get
            {
                return waterTarget;
            }
            set
            {
                waterTarget = value;
            }
        }

        private int waterDrank;
        
        public int WaterDrank
        {
            get
            {
                return waterDrank;
            }
        }

        public void AddWater(int water)
        {
            waterDrank += water;
        }
    }
}
