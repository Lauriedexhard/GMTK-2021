using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotHealth : MonoBehaviour
{


    public GameObject parent;

    public float FlightTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FlightTime -= Time.deltaTime;

        if (FlightTime < 0.01)
        {
            Destroy(parent);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            Debug.Log("KAboom");
            // ShipSR.sprite = newSprite;
            Destroy(parent);

        }



    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Debug.Log("KAboom");
            //ShipSR.sprite = newSprite;
            Destroy(parent);

        }
    }
}
