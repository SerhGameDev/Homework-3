using System.Collections;
using UnityEngine;

public class Human : Enemy
{
    public override void Acept(IEnemySpawnScalesVisitor visitor) => visitor.GetValueScales(this);
}