using UnityEngine;

public class PowerUpSpawner
{
    private readonly PowerUpsFactory powerUpsFactory;

    public PowerUpSpawner(PowerUpsFactory powerUpsFactory)
    {
        this.powerUpsFactory = powerUpsFactory;
    }
        
    // Logic

    public void SpawnPowerUp(string id, Vector3 transformPosition)
    {
        var projectileTemplate = powerUpsFactory.Create(id);
        projectileTemplate.transform.position = transformPosition;
    }
}