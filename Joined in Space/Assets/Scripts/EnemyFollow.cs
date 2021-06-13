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

    public Transform Firepoint;
    public GameObject ENElaserprefab;
    public float bulletForce = 20f;
    public float charge;
    public GameObject Shootship;
    public bool Ready;

    public AudioSource AS;
    public AudioClip Laz2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        AS = Camera.main.GetComponent<AudioSource>();


        if(Shootship.tag == "ShootEnemy")
        {
            if (charge < 100)
            {
                charge += Time.deltaTime * 75;
            }

            if (charge > 100)
            {
                Ready = true;


            }
            if(Ready == true && followmode == true)
            {
              
                shoot();
                charge = 0;
                Ready = false;
                AS.PlayOneShot(Laz2, 0.1f);
            }
        }


        if (followmode == true)
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

    void shoot()
    {
        GameObject bullet = Instantiate(ENElaserprefab, Firepoint.position, Firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(Firepoint.up * bulletForce, ForceMode2D.Impulse);
    }
    private void FixedUpdate()
    {

    }

}
