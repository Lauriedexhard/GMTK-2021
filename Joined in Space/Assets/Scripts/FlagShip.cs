using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagShip : MonoBehaviour
{

    public GameObject enemy;

    public GameObject enemy2;

    public float flagshipHealth = 25;

    public Text HealthDisp;
    public GameObject health;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

        health = GameObject.Find("FlagShipHealth");
        health.GetComponent<Text>().enabled = true;

        HealthDisp = GameObject.Find("FlagShipHealth").GetComponent<Text>();


        if (flagshipHealth < 1)
        {

            WinGameOver.youwin = true;
            enemy.SetActive(false);
            enemy2.SetActive(false);

            ParticleSystem ps = enemy.GetComponent<ParticleSystem>();
            ps.Play();
        }

        HealthDisp.text = "Flag ShipHealth " + flagshipHealth;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            flagshipHealth--;
        }
        else if (collision.gameObject.layer == 6)
        {
            flagshipHealth--;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            flagshipHealth--;
        }
    }


}
