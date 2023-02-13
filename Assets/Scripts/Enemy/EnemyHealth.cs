using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    
    public int health;
    public Animator animator;




    public void TakeDamage(int damage)
    {
        health -= damage;
        animator.SetTrigger("BeingHit");
        Debug.Log("Damage Taken!");

        if (health <= 0)
        {
            animator.SetTrigger("EnemyDie");
            Invoke("DestroyEnemy", 1f);
        }
    }

    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }

}