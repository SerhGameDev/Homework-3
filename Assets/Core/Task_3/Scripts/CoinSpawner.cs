using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private float _spawnRadius = 5.0f;
    [SerializeField] private int _numberOfCoins = 10;

    private void Start()
    {
        SpawnCoins();
    }

    private void SpawnCoins()
    {
        for (int i = 0; i < _numberOfCoins; i++)
        {
            Vector3 randomSpawnPosition = GetRandomSpawnPosition();
            Instantiate(_coinPrefab, randomSpawnPosition, Quaternion.identity);
        }
    }

    private Vector3 GetRandomSpawnPosition()
    {
        Vector2 randomCircle = Random.insideUnitCircle * _spawnRadius;
        Vector3 randomPosition = new Vector3(randomCircle.x, 0.0f, randomCircle.y);
        randomPosition += transform.position;
        return randomPosition;
    }
}
