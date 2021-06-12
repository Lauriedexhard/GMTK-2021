using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{

    GameObject player;

    public GameObject shipPostion;

    public bool isclose = false;

    public int howmany = 0;

    public float magSpeed = 0.1f;

   // bool magon = false;

    public float distance;

    //Vector2 playerpostion;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            player = collision.gameObject;
            isclose = true;
            howmany++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            howmany--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(isclose == true)
        {
            if (Input.GetMouseButton(1))
            {
                Debug.Log("magnets on");
               // magon = true;
                //transform.position = Vector2.Lerp(transform.position, player.transform.position, Time.deltaTime);

                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, magSpeed / distance * Time.deltaTime);
            }

            distance = Vector2.Distance(shipPostion.transform.position, player.transform.position);


        }

        //if (Input.GetMouseButtonUp(1))
        //{
        //    magon = false;
        //}


        //if (magon == true)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, player.transform.position, magSpeed / distance * Time.deltaTime);
        //}
        //playerpostion = player.transform.position;

        if (howmany<1)
        {
            isclose = false;
            player = null;
        }





        
    }
}
