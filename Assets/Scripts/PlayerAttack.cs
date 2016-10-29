﻿using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    public GameObject target;
    public float attackTimer;
    public float coolDown;

    // Use this for initialization
    void Start()
    {
        attackTimer = 0;
        coolDown = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (attackTimer > 0)
            attackTimer -= Time.deltaTime;

        if (attackTimer < 0)
            attackTimer = 0;

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if (attackTimer == 0)
            {
                Attack();
                attackTimer = coolDown;
            }
        }
    }

    private void Attack()
    {
        float distance = Vector3.Distance(target.transform.position, transform.position);
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float direction = Vector3.Dot(dir, transform.forward);
        Debug.Log(direction);



    }
}
