namespace Assets.Core.Task_5.Scripts
{
    public class Race : IStatModifier
    {
        public virtual BaseStats ModifyStats(BaseStats baseStats) => baseStats;
    }
}