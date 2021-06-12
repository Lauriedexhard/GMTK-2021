using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject laserprefab;

    public float bulletForce = 20f;

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
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }


    }

    void Shoot()
    {
        GameObject bullet = Instantiate(laserprefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
