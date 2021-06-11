using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector : MonoBehaviour
{

    GameObject Player;

    public GameObject Ship;

    //public Rigidbody2D playership;

    public Collider2D C2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            Player = collision.gameObject;
            Ship.transform.parent = Player.transform;
            Debug.Log("bang");
            Ship.layer = 6;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
