using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public GameObject itSelf;

    public Quaternion playerRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, itSelf.transform.position, 10000 * Time.deltaTime);

        playerRotation = itSelf.transform.rotation;

        transform.rotation = playerRotation;

        //var euler = itSelf.transform.rotation.eulerAngles;   //get target's rotation
        //var rot = Quaternion.Euler(0, 0, euler.y); //transpose values
        //transform.rotation = rot;                  //set my rotation
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            WinGameOver.Gameover = true;
            itSelf.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            WinGameOver.Gameover = true;
            itSelf.SetActive(false);
        }
    }
}
