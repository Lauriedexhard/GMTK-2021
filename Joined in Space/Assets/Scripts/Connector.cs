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
                Player = GameObject.Find("Player");
                Ship.transform.parent = Player.transform;
                Debug.Log("bang");
                Ship.layer = 6;
                Destroy(Magnetring);

                //Ship Ball Stuff

                if (Ship.name == "BasicShip")
                {
                    ShipBallControllor.PowerUsed = ShipBallControllor.PowerUsed + 5;
                    ShipBallControllor.Mass = ShipBallControllor.Mass + 10;
                }

                if (Ship.name == "GenShip")
                {
                    ShipBallControllor.PowerUsed = ShipBallControllor.PowerUsed - 20;
                    ShipBallControllor.Mass = ShipBallControllor.Mass + 10;
                }

                if (Ship.name == "ThrustShip")
                {
                    ShipBallControllor.PowerUsed = ShipBallControllor.PowerUsed + 5;
                    ShipBallControllor.Mass = ShipBallControllor.Mass - 40;
                }

                if (Ship.name == "4GunShip")
                {
                    ShipBallControllor.PowerUsed = ShipBallControllor.PowerUsed + 15;
                    ShipBallControllor.Mass = ShipBallControllor.Mass + 10;
                }

                if (Ship.name == "RocketShip")
                {
                    ShipBallControllor.PowerUsed = ShipBallControllor.PowerUsed + 15;
                    ShipBallControllor.Mass = ShipBallControllor.Mass + 10;
                }


            }


//            ShipShoot.joinedToShip = true;

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
