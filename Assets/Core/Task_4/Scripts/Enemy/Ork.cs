using UnityEngine;

public class Ork : Enemy
{
    public override void Acept(IEnemySpawnScalesVisitor visitor) => visitor.GetValueScales(this);
}