using UnityEngine;

public class EnemySpawner
{
    private readonly EnemiesFactory _enemiesFactory;

    public EnemySpawner(EnemiesFactory enemiesFactory)
    {
        _enemiesFactory = enemiesFactory;
    }
        
    // Logic

    public void SpawnEnemy(string id, Vector2 position)
    {
        var enemy = _enemiesFactory.Create(id);
        enemy.transform.position = position;
    }
}