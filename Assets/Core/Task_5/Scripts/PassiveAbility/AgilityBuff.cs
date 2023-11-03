namespace Assets.Core.Task_5.Scripts
{
    public class AgilityBuff : PassiveAbility
    {
        public override BaseStats ModifyStats(BaseStats baseStats)
        {
            baseStats.Agility += 2;
            return baseStats;
        }
    }
}