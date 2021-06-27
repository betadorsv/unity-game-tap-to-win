using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 50;
    private float minX = -12;
    private float maxX = 12;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        VirusHealth virusHealth = collision.GetComponent<VirusHealth>();
       // VirusLTR virusLTR = collision.GetComponent<VirusLTR>();
       // VirusRTL virusRTL = collision.GetComponent<VirusRTL>();
        if (virusHealth != null)
        {
            virusHealth.takeDamage(damage);
        }
        if (collision.tag == "Virus") { 
        Destroy(gameObject);
        }
    }
    void Update()
    {
        if (transform.position.x < minX || transform.position.x > maxX)
        {
            Destroy(this.gameObject);
        }

    }

}
