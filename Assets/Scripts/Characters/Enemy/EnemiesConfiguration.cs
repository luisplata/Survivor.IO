using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Enemies configuration")]
public class EnemiesConfiguration : ScriptableObject
{
    [SerializeField] private Enemy[] enemies;
    private Dictionary<string, Enemy> idToEnemy;

    private void Awake()
    {
        idToEnemy = new Dictionary<string, Enemy>(enemies.Length);
        foreach (var powerUp in enemies)
        {
            idToEnemy.Add(powerUp.Id, powerUp);
        }
    }

    public Enemy GetEnemyPrefabById(string id)
    {
        if (!idToEnemy.TryGetValue(id, out var enemy))
        {
            throw new Exception($"Enemy with id {id} does not exit");
        }
        return enemy;
    }
}