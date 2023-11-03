using UnityEngine;

public class Elf : Enemy
{
    public override void Acept(IEnemySpawnScalesVisitor visitor) => visitor.GetValueScales(this); 
}