using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour, IAttackMediator
{
    [SerializeField] private PowerUpsConfiguration powerUpsConfiguration;
    [SerializeField] private GameObject pointToSpawn;
    private List<SkillTemplate> habilities;
    private PowerUpsFactory powerUpsFactory;
    private PowerUpSpawner powerUpSpawner;


    private void Start()
    {
        habilities = new List<SkillTemplate>();
        
        habilities.Add(new ThrowLaser(this,2));
        
        powerUpsFactory = new PowerUpsFactory(Instantiate(powerUpsConfiguration));
        powerUpSpawner = new PowerUpSpawner(powerUpsFactory);
    }

    private void Update()
    {
        foreach (var hability in habilities)
        {
            hability.Run(Time.deltaTime);
        }
    }

    public void Spawn(string id)
    {
        powerUpSpawner.SpawnPowerUp(id,pointToSpawn.transform.position);
    }
}