using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    public float RocketSpeed = 8f;

    public bool followmode = false;

    public GameObject Target;
   // Vector2 TargetPos;

    public Camera cam;


    public Rigidbody2D Rocketrb;

    public float rocketForce = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (followmode == true)
            {
                transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, RocketSpeed * Time.deltaTime);
            }
        }
        //cam = Camera.main;

        //TargetPos = cam.ScreenToWorldPoint(Target.transform.position);

        Vector3 targ = Target.transform.position;
        targ.z = 0f;

        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if(Target == null)
        {

            followmode = false;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            followmode = true;
            Target = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        followmode = false;
    }

    private void FixedUpdate()
    {
        //Vector2 lookDir = TargetPos - Rocketrb.position;
        //float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        //Rocketrb.rotation = angle;
    }
}
