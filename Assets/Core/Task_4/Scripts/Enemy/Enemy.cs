using System;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
   public abstract void Acept(IEnemySpawnScalesVisitor visitor);
}
