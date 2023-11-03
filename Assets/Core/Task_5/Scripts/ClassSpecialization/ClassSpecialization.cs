namespace Assets.Core.Task_5.Scripts
{
    public class ClassSpecialization : IStatModifier
    {
        public virtual BaseStats ModifyStats(BaseStats baseStats) => baseStats;
    }
}