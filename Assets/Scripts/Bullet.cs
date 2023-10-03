using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    private float lifespan = 1.75f;
    private float birth_time;
    public int direction;

    private Vector2 velocity;

    // 1 - up
    // 2 - down
    // 3 - right
    // 4 - left

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        birth_time = Time.time;

        if (direction == 1)
        {
            velocity = new Vector2(0.0f, speed * transform.localScale.y);
        } else if (direction == 2)
        {
            velocity = new Vector2(0.0f, -speed * transform.localScale.y);
        } else if (direction == 3)
        {
            velocity = new Vector2(speed * transform.localScale.x, 0.0f);
        } else if (direction == 4)
        {
            velocity = new Vector2(-speed * transform.localScale.x, 0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - birth_time > lifespan) Destroy(gameObject);

        rb.velocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy1>().Die();
            Destroy(gameObject);
        }
    }
}
