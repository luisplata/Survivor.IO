using UnityEngine;

public class Laser : ProjectileTemplate
{
    protected override void Doing()
    {
        Debug.Log($"Find the next enemy, calculate the direction rotate and move to enemy");
        var distance = 1000f;
        var direction = Vector2.zero;
        //Find to circle raycast and filter
        //https://docs.unity3d.com/ScriptReference/Physics2D.CircleCastAll.html
        var findGameObjectsWithTag = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var enemy in findGameObjectsWithTag)
        {
            var distanceLocal = Vector2.Distance(transform.position, enemy.transform.position);
            if (distanceLocal <= distance)
            {
                distance = distanceLocal;
                direction = enemy.transform.position - transform.position;
            }
        }
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        rigi.velocity = direction * velocity;
    }

    protected override void CollisionAction(Enemy enemy)
    {
        Debug.Log($"Collision with Enemy; Apply damage that is {damage} and is logic to enemy is dead or not");
        enemy.Sub(damage);
    }
}