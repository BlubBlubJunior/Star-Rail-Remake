using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAttack : MonoBehaviour
{

    public float basicAttack;
    public LayerMask enemyLayer;
    public bool attackRay;

    void Update()
    {
        if (attackRay == true)
        {
            Ray();
        }
    }

    public void Attack()
    {
        attackRay = true;
       Debug.Log("hello");
    }

    void Ray()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button click.
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, enemyLayer))
            {
                // The ray hit an enemy.
                //GameObject enemy = hit.collider.gameObject;
                //AttackEnemy(enemy);
                Debug.Log("hello2");
            }
        }
    }
}
