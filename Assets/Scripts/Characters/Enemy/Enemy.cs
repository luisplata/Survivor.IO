using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected string id;
    [SerializeField] protected float hp;

    public string Id => id;

    public void Sub(float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(gameObject, 2);
        }
    }
}