namespace Assets.Core.Task_5.Scripts
{
    public class IntelligenceBuff : PassiveAbility
    {
        public override BaseStats ModifyStats(BaseStats baseStats)
        {
            baseStats.Intelligence += 2;
            return baseStats;
        }
    }
}