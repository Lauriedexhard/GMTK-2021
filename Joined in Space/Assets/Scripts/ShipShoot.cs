using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour
{
    public Transform firepoint;
    public Transform firepoint2;
    public Transform firepoint3;
    public Transform firepoint4;
    public GameObject laserprefab;

    public GameObject Rocketprefab;

    public float bulletForce = 20f;
    public float rocketForce = 8f;

    public GameObject ShipitsSelf;

  //  public static bool joinedToShip = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(ShipitsSelf.layer == 6)
        {
            if (Input.GetButton("Fire1"))
            {
                if (ShipBallControllor.GunReady == true)
                {
                    Shoot();
                    ShipBallControllor.Charge = 0;
                }

            }
        }


    }

    void Shoot()
    {

        if(ShipitsSelf.name == "BasicShip")
        {
            GameObject bullet = Instantiate(laserprefab, firepoint.position, firepoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
        }


        else if(ShipitsSelf.name == "4GunShip")
        {

            GameObject bullet = Instantiate(laserprefab, firepoint.position, firepoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);

            GameObject bullet2 = Instantiate(laserprefab, firepoint2.position, firepoint2.rotation);
            Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
            rb2.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);

            GameObject bullet3 = Instantiate(laserprefab, firepoint3.position, firepoint3.rotation);
            Rigidbody2D rb3 = bullet3.GetComponent<Rigidbody2D>();
            rb3.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);

            GameObject bullet4 = Instantiate(laserprefab, firepoint4.position, firepoint4.rotation);
            Rigidbody2D rb4 = bullet4.GetComponent<Rigidbody2D>();
            rb4.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
        }

        else if(ShipitsSelf.name == "RocketShip")
        {
            GameObject bullet = Instantiate(Rocketprefab, firepoint.position, firepoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firepoint.up * rocketForce, ForceMode2D.Impulse);

            GameObject bullet2 = Instantiate(Rocketprefab, firepoint2.position, firepoint2.rotation);
            Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
            rb2.AddForce(firepoint.up * rocketForce, ForceMode2D.Impulse);
        }

    }
}
