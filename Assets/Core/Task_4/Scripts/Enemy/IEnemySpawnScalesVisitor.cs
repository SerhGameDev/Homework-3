public interface IEnemySpawnScalesVisitor
{
    int GetValueScales(Human human);
    int GetValueScales(Ork ork);
    int GetValueScales(Elf elf);
}