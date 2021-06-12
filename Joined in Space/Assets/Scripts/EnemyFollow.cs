using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float enemySpeed = 10f;

    public bool followmode = false;

    public GameObject Target;
    //Vector2 TargetPos;

    public Camera cam;

    public Rigidbody2D Enemyrb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(followmode == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, enemySpeed * Time.deltaTime);
        }

        Vector3 targ = Target.transform.position;
        targ.z = 0f;

        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        //cam = Camera.main;

        //TargetPos = cam.ScreenToWorldPoint(Target.transform.position);


        //Vector2 lookDir = TargetPos - Enemyrb.position;
        //float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        //Enemyrb.rotation = angle;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            followmode = true;
            Target = collision.gameObject;
        }
    }

    private void FixedUpdate()
    {

    }

}
