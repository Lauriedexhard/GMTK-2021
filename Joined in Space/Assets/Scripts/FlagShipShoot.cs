using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagShipShoot : MonoBehaviour
{
    public float enemySpeed = 3f;

    public bool followmode = false;

    public GameObject Target;
    //Vector2 TargetPos;

    public Camera cam;

    public Rigidbody2D Enemyrb;

    public Transform Firepoint;
    public Transform firepoint2;
    public Transform firepoint3;
    public Transform firepoint4;
    public Transform firepoint5;
    public Transform firepoint6;
    public Transform firepoint7;

    public GameObject FLGlaserprefab;
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

        if (charge < 100)
            {
                charge += Time.deltaTime * 75;
            }

            if (charge > 100)
            {
                Ready = true;


            }
            if (Ready == true )
            {

                shoot();
                charge = 0;
                Ready = false;
            AS.PlayOneShot(Laz2, 0.1f);
        }


        Target = GameObject.Find("Player");

            transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, enemySpeed * Time.deltaTime);


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



    void shoot()
    {
        GameObject bullet = Instantiate(FLGlaserprefab, Firepoint.position, Firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(Firepoint.up * bulletForce, ForceMode2D.Impulse);

        GameObject bullet2 = Instantiate(FLGlaserprefab, firepoint2.position, firepoint2.rotation);
        Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
        rb2.AddForce(firepoint2.up * bulletForce, ForceMode2D.Impulse);

        GameObject bullet3 = Instantiate(FLGlaserprefab, firepoint3.position, firepoint3.rotation);
        Rigidbody2D rb3 = bullet3.GetComponent<Rigidbody2D>();
        rb3.AddForce(firepoint3.up * bulletForce, ForceMode2D.Impulse);

        GameObject bullet4 = Instantiate(FLGlaserprefab, firepoint4.position, firepoint4.rotation);
        Rigidbody2D rb4 = bullet4.GetComponent<Rigidbody2D>();
        rb4.AddForce(firepoint4.up * bulletForce, ForceMode2D.Impulse);


        GameObject bullet5 = Instantiate(FLGlaserprefab, firepoint5.position, firepoint5.rotation);
        Rigidbody2D rb5 = bullet5.GetComponent<Rigidbody2D>();
        rb5.AddForce(firepoint5.up * bulletForce, ForceMode2D.Impulse);

        GameObject bullet6 = Instantiate(FLGlaserprefab, firepoint6.position, firepoint6.rotation);
        Rigidbody2D rb6 = bullet6.GetComponent<Rigidbody2D>();
        rb6.AddForce(firepoint6.up * bulletForce, ForceMode2D.Impulse);

        GameObject bullet7 = Instantiate(FLGlaserprefab, firepoint7.position, firepoint7.rotation);
        Rigidbody2D rb7 = bullet7.GetComponent<Rigidbody2D>();
        rb7.AddForce(firepoint7.up * bulletForce, ForceMode2D.Impulse);
    }
    private void FixedUpdate()
    {

    }
}
