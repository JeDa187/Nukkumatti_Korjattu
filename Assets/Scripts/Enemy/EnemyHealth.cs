using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    
    public int health;
   
   


    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Damage Taken!");

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}