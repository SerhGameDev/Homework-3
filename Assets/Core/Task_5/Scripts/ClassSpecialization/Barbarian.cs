namespace Assets.Core.Task_5.Scripts
{
    public class Barbarian : ClassSpecialization
    {
        public override BaseStats ModifyStats(BaseStats baseStats)
        {
            baseStats.Strength *= 2; 
            return baseStats;
        }
    }
}