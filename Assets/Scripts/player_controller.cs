using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    private Transform tr;
    private Rigidbody2D rb;

    public float movement_speed;

    private float x_pos;
    private float y_pos;

    private float x_vel;
    private float y_vel;
    


    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        x_pos = transform.position.x;
        y_pos = transform.position.y;

        x_vel = 0;
        y_vel = 0;

        if (Input.GetKey(KeyCode.W)) y_vel += movement_speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S)) y_vel += -movement_speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) x_vel += -movement_speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) x_vel += movement_speed * Time.deltaTime;



        rb.MovePosition(new Vector2(x_pos + x_vel, y_pos + y_vel));
    }
}
