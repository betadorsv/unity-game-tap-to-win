using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private float screenR = 17;
    private float screenL = -14;
    private int random;
    private int direction;

    // Start is called before the first frame update
    void Start()
    {

        random = Random.Range(-1, 1);
        if (random < 0)
        {
            direction = -1;
        }
        else if (random >= 0)
        {
            direction = 1;
        }

        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(direction * speed, 0);


        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < screenL|| transform.position.x > screenR)
        {
            Destroy(this.gameObject);
        }

    }
}
