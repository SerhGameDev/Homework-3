namespace Assets.Core.Task_5.Scripts
{
    public class PassiveAbility : IStatModifier
    {
        public virtual BaseStats ModifyStats(BaseStats baseStats) => baseStats;
    }
}