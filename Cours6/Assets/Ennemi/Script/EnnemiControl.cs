using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiControl : MonoBehaviour, damageableBullet
{
    private GameObject player;
    private Rigidbody myRigidBody;
    public void TakeDamage(int damage)
    {
        Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        myRigidBody.MovePosition(Vector3.MoveTowards(transform.position, player.transform.position, 100 * Time.deltaTime));
    }
}
