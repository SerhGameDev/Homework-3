using UnityEngine;

public class EnemyFabrica
{
    private EnemySpawnScalesVisitor _enemySpawnScalesVisitor = new EnemySpawnScalesVisitor();
    private int _valueScales;
    private int _maxValueScales;
    public EnemyFabrica(int maxValueScales) => _maxValueScales = maxValueScales;

    public void Spawn(EnemyType type)
    {
        if (_maxValueScales < _valueScales + GetValueScales(type))
        {
            Debug.LogError($"Вы пытаетесь создать много врагов {_valueScales + GetValueScales(type)}");
            return;
        }

        _valueScales += GetValueScales(type);

        Debug.Log(_valueScales); 
    }
    private int GetValueScales(EnemyType type)
    {
        switch (type)
        {
            case EnemyType.Human:
                return _enemySpawnScalesVisitor.GetValueScales(new Human());
            case EnemyType.Ork:
                return _enemySpawnScalesVisitor.GetValueScales(new Ork());
            case EnemyType.Elf:
                return _enemySpawnScalesVisitor.GetValueScales(new Elf());
                default:
                return 0;
        }
    }
}