using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllor : MonoBehaviour
{

    public Rigidbody2D rb;

    public float speed = 1f;

    public float sidespeed = 0.5f;

    public float maxVelocity = 3;

    public float rotationSpeed;

    public Camera cam;

    Vector2 mousePos;

    public int connectedShips = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yAxis = Input.GetAxis("Vertical");
        float xAxis = Input.GetAxis("Horizontal");


        ThrustForward(yAxis);
        ThrustSide(xAxis);

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void ClampVelocity()
    {
        float x = Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity);
        float y = Mathf.Clamp(rb.velocity.y, -maxVelocity, maxVelocity);

        rb.velocity = new Vector2(x, y);
    }

    public void ThrustForward(float amount)
    {
        Vector2 force = transform.up * amount * speed * Time.deltaTime;

        rb.AddForce(force);
    }

    public void ThrustSide(float amount)
    {
        Vector2 force = transform.right * amount * sidespeed * Time.deltaTime;

        rb.AddForce(force);
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
