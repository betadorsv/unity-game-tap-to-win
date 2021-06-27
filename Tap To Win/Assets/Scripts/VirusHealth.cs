using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 100;
    public GameObject deathEffect;
    public void takeDamage(int damage)
    {
        health -= damage;
        {
            if (health <= 0)
            {
                Die();
            }
        }
    }

    // Update is called once per frame
    void Die()
    {
        Destroy(gameObject);
    }
}
