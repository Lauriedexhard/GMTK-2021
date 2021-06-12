using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour
{

    public Sprite newSprite;

    public GameObject Mag;

    public SpriteRenderer ShipSR;

    public BoxCollider2D BC;

    public GameObject ShipCh;
    public GameObject PlayerCh;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            transform.parent = null;
            gameObject.layer = 9;
            ShipSR.sprite = newSprite;
            GetComponent<Collider2D>().isTrigger = true;
            Destroy(Mag);

            //ShipBallControllor.PowerUsed = ShipBallControllor.PowerUsed - 5;
            //ShipBallControllor.Mass = ShipBallControllor.Mass - 10;

            //Ship Ball
            if (ShipCh.transform.parent  == PlayerCh)
            {
                ShipBallControllor.PowerUsed = ShipBallControllor.PowerUsed - 5;
                ShipBallControllor.Mass = ShipBallControllor.Mass - 10;
            }
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
