using UnityEngine;

public class ThrowLaser : SkillTemplate
{
    public ThrowLaser(IAttackMediator attackMediator, float time) : base(attackMediator, time)
    {
    }
    protected override void Execute()
    {
        _attackMediator.Spawn("laser");
    }
}