using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusRTL : MonoBehaviour
{

    public float speed = 5.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private float screenX=-17;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);


        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z));
    }
  
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < screenX)
        {
            Destroy(this.gameObject);
        }
        
    }

}
