public class EnemySpawnScalesVisitor : IEnemySpawnScalesVisitor
{
    public int GetValueScales(Human human) => 2;
    public int GetValueScales(Ork ork) => 10;
    public int GetValueScales(Elf elf) => 5;

}