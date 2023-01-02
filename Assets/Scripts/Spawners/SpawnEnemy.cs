using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private EnemiesConfiguration enemiesConfiguration;
    [SerializeField] private int radius;
    [SerializeField] private int frequencyToIncrementEnemies;

    [Header("Configuration of Spawn")] 
    [SerializeField] private float timeToInterval;
    
    private EnemiesFactory enemiesFactory;
    private EnemySpawner enemySpawner;

    private float deltatimeLocal;
    private int _countHordes;
    private int _enemies = 1;

    private void Start()
    {
        enemiesFactory = new EnemiesFactory(Instantiate(enemiesConfiguration));
        enemySpawner = new EnemySpawner(enemiesFactory);
    }
    
    private void FixedUpdate()
    {
        deltatimeLocal += Time.fixedDeltaTime;
        if (deltatimeLocal >= timeToInterval)
        {
            deltatimeLocal = 0;
            _countHordes++;
            if (_countHordes >= frequencyToIncrementEnemies)
            {
                _countHordes = 0;
                for (int i = 0; i < _enemies; i++)
                {
                    Spawn();   
                }
                _enemies++;
            }
        }
    }

    private void Spawn()
    {
        var insideUnitCircle = Random.insideUnitCircle;
        insideUnitCircle.Normalize();
        insideUnitCircle *= radius;
        insideUnitCircle += (Vector2)player.transform.position;
        enemySpawner.SpawnEnemy("zombie", insideUnitCircle);
    }
}
