namespace Assets.Core.Task_5.Scripts
{
    public class Human : Race
    {
        public override BaseStats ModifyStats(BaseStats baseStats)
        {
            baseStats.Agility += 1;
            baseStats.Intelligence += 2;
            return baseStats;
        }
    }
}