using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Power up configuration")]
public class PowerUpsConfiguration : ScriptableObject
{
    [SerializeField] private ProjectileTemplate[] powerUps;
    private Dictionary<string, ProjectileTemplate> idToPowerUp;

    private void Awake()
    {
        idToPowerUp = new Dictionary<string, ProjectileTemplate>(powerUps.Length);
        foreach (var powerUp in powerUps)
        {
            idToPowerUp.Add(powerUp.Id, powerUp);
        }
    }

    public ProjectileTemplate GetPowerUpPrefabById(string id)
    {
        if (!idToPowerUp.TryGetValue(id, out var powerUp))
        {
            throw new Exception($"PowerUp with id {id} does not exit");
        }
        return powerUp;
    }
}