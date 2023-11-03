namespace Assets.Core.Task_5.Scripts
{
    public class Elf : Race
    {
        public override BaseStats ModifyStats(BaseStats baseStats)
        {
            baseStats.Agility += 7;
            baseStats.Intelligence += 2;
            return baseStats;
        }
    }
}