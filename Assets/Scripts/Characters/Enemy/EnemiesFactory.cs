using UnityEngine;

public class EnemiesFactory
{
    private readonly EnemiesConfiguration enemiesConfiguration;

    public EnemiesFactory(EnemiesConfiguration enemiesConfiguration)
    {
        this.enemiesConfiguration = enemiesConfiguration;
    }
        
    public Enemy Create(string id)
    {
        var prefab = enemiesConfiguration.GetEnemyPrefabById(id);

        return Object.Instantiate(prefab);
    }
}