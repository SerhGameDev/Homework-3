using UnityEngine;

namespace Assets.Core.Task_5.Scripts
{
    public class PlayerFactory : MonoBehaviour
    {
        [SerializeField] private RaceType _raceType;
        [SerializeField] private SpecializationType _specializationType;
        [SerializeField] private PassiveAbilityType _passiveAbilityType;

        private void Start()
        {
            CreatPlayer();
        }

        public void CreatPlayer()
        {
            Race race = SelecteRace(_raceType);
            ClassSpecialization specialization = SelecteSpecialization(_specializationType);
            PassiveAbility ability = SelectePassiveAbility(_passiveAbilityType);

            StatsConfigurator statsConfigurator = new StatsConfigurator(race, specialization, ability);

            new GameObject().AddComponent<Player>().Stats = statsConfigurator.GetStats();
        }

        private Race SelecteRace(RaceType raceType)
        {
            switch (raceType)
            {
                case RaceType.Human:
                    return new Human();
                case RaceType.Ork:
                    return new Ork();
                case RaceType.Elf:
                    return new Elf();
                    default: 
                    return null;
            }
        }
        private ClassSpecialization SelecteSpecialization(SpecializationType specializationType)
        {
            switch (specializationType)
            {
                case SpecializationType.Barbarian:
                    return new Barbarian();
                case SpecializationType.Mage:
                    return new Mage();
                case SpecializationType.Thief:
                    return new Thief();
                default:
                    return null;
            }
        }
        private PassiveAbility SelectePassiveAbility(PassiveAbilityType _passiveAbilityType)
        {
            switch (_passiveAbilityType)
            {
                case PassiveAbilityType.IntelligenceBuff:
                    return new IntelligenceBuff();
                case PassiveAbilityType.StrengthBuff:
                    return new StrengthBuff();
                case PassiveAbilityType.AgilityBuff:
                    return new AgilityBuff();
                default:
                    return null;
            }
        }
    }
}