using UnityEngine;

public class PowerUpsFactory
{
    private readonly PowerUpsConfiguration powerUpsConfiguration;

    public PowerUpsFactory(PowerUpsConfiguration powerUpsConfiguration)
    {
        this.powerUpsConfiguration = powerUpsConfiguration;
    }
        
    public ProjectileTemplate Create(string id)
    {
        var prefab = powerUpsConfiguration.GetPowerUpPrefabById(id);

        return Object.Instantiate(prefab);
    }
}