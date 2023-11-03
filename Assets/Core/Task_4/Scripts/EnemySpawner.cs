using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int _maxValueScales = 0;
    [SerializeField] private EnemyType _enemySpawnType;

    private EnemyFabrica _enemyFabrica;

    private void Awake()
    {
        _enemyFabrica = new EnemyFabrica(_maxValueScales);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _enemyFabrica.Spawn(_enemySpawnType);
    }
}