using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector : MonoBehaviour
{

    GameObject Player;

    public GameObject Ship;

    public Collider2D C2D;

    public GameObject Magnetring;







    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            if(Input.GetMouseButton(1))
            {
                Player = collision.gameObject;
                Ship.transform.parent = Player.transform;
                Debug.Log("bang");
                Ship.layer = 6;
                Destroy(Magnetring);
            }


//            ShipShoot.joinedToShip = true;

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
