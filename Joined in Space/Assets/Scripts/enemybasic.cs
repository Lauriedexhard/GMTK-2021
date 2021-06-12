using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybasic : MonoBehaviour
{

    public GameObject enemy;

    public GameObject enemy2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            Destroy(enemy);
            Destroy(enemy2);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Destroy(enemy);
            Destroy(enemy2);
        }
    }


}
