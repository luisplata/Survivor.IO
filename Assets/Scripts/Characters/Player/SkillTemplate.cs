public abstract class SkillTemplate
{
    protected readonly IAttackMediator _attackMediator;
    private float delay;
    private float deltatimeLocal;
    
    protected SkillTemplate(IAttackMediator attackMediator, float time)
    {
        _attackMediator = attackMediator;
        delay = time;
    }

    public void Run(float deltaTime)
    {
        deltatimeLocal += deltaTime;
        if (deltatimeLocal >= delay)
        {
            Execute();
            deltatimeLocal = 0;
        }
    }

    protected abstract void Execute();
}