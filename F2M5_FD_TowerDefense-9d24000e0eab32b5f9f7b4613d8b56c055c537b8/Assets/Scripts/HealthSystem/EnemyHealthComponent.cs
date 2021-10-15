using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthComponent : HealthComponent
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
        }
    }

    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        // update je health bar
    }

    protected override void Death()
    {
        base.Death();
        Destroy(gameObject);
    }
}
