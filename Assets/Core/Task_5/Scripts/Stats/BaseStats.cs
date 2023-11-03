namespace Assets.Core.Task_5.Scripts
{
    public class BaseStats
    {
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }

        public BaseStats(int strength, int intelligence, int agility)
        {
            Strength = strength;
            Intelligence = intelligence;
            Agility = agility;
        }
    }
}