using System;
using UnityEngine;

public class InputEnemy : InputCustom
{
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public override Vector2 Direction
    {
        get
        {
            if (player == null)
            {
                return Vector2.zero;
            }
            else
            {
                return (player.transform.position - transform.position).normalized;   
            }
        }
    }
}