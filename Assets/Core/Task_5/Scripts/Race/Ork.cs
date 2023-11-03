namespace Assets.Core.Task_5.Scripts
{
    public class Ork : Race
    {
        public override BaseStats ModifyStats(BaseStats baseStats)
        {
            baseStats.Strength += 5;
            baseStats.Intelligence -= 2;
            baseStats.Agility -= 4;
            return baseStats;
        }
    }
}
