using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletHealth : MonoBehaviour
{

    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Debug.Log("KAboom");
            // ShipSR.sprite = newSprite;
            parent.SetActive(false);

        }



    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Debug.Log("KAboom");
            //ShipSR.sprite = newSprite;
            parent.SetActive(false);

        }
    }
}
