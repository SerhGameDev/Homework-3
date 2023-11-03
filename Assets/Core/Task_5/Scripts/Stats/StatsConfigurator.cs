namespace Assets.Core.Task_5.Scripts
{
    public class StatsConfigurator
    {
        private BaseStats baseStats;

        public StatsConfigurator(Race race, ClassSpecialization specialization, PassiveAbility passiveAbility)
        {
            baseStats = new BaseStats(1, 1, 1);

            baseStats = race.ModifyStats(baseStats);
            baseStats = specialization.ModifyStats(baseStats);
            baseStats = passiveAbility.ModifyStats(baseStats);
        }

        public BaseStats GetStats()
        {
            return baseStats;
        }
    }
}