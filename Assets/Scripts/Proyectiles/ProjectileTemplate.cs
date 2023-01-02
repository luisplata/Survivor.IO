using System;
using UnityEngine;

public abstract class ProjectileTemplate : MonoBehaviour
{
    [SerializeField] private string id;
    [SerializeField] protected Rigidbody2D rigi;
    [SerializeField] protected float damage;
    [SerializeField] protected float velocity;
    public string Id => id;

    private void Start()
    {
        Doing();
        Destroy(gameObject, 10);
    }

    protected abstract void Doing();

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.transform.CompareTag("Enemy")) return;
        CollisionAction(col.transform.GetComponent<Enemy>());
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.transform.CompareTag("Enemy")) return;
        CollisionAction(col.transform.GetComponent<Enemy>());
    }

    protected abstract void CollisionAction(Enemy getComponent);
}