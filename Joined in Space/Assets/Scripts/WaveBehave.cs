using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveBehave : MonoBehaviour
{

    public Text Wave;

    public Text NextWaveMess;
    public float MessDur;
    public bool MessShow = false;

    public float countdown1 = 30f;
    public float countdown2 = 45f;
    public float countdown3 = 60f;

    public float currentWave = 1f;

    public Collider2D NextWaveBox;
    public Rigidbody rb;

    public bool Wave2Ready;
    public bool Wave3Ready;
    public bool WaveBossReady;


    public GameObject Wave2;
    public GameObject Wave3;
    public GameObject WaveBoss;


    public float rotationSpeed;

    public Camera cam;

    public GameObject Next;
    public Vector3 targ ;
    public GameObject pointer;

    public Vector3 Bosstarg;
    public GameObject BossPointer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if(currentWave == 1)
        {
            Wave.text = "Wave 1";
        }
        if (currentWave == 1.5)
        {
            Wave.text = "Wave 1";
        }
        if (currentWave == 2)
        {
            Wave.text = "Wave 2";
        }
        if (currentWave == 2.5)
        {
            Wave.text = "Wave 2";
        }
        if (currentWave == 3)
        {
            Wave.text = "Wave 3";
        }
        if (currentWave == 3.5)
        {
            Wave.text = "Wave 3";
        }
        if (currentWave == 4)
        {
            Wave.text = "BOSS";
        }
        if (currentWave == 4.5)
        {
            Wave.text = "BOSS";
        }
        targ = Next.transform.position;


        Vector3 objectPos = pointer.transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg - 90f;
        pointer.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        

        //Vector3 BossobjectPos = pointer.transform.position;
        //Bosstarg.x = Bosstarg.x - BossobjectPos.x;
        //Bosstarg.y = Bosstarg.y - BossobjectPos.y;

        //float Bossangle = Mathf.Atan2(Bosstarg.y, Bosstarg.x) * Mathf.Rad2Deg - 90f;
        //BossPointer.transform.rotation = Quaternion.Euler(new Vector3(0, 0, Bossangle));

        if (currentWave == 1.5)
        {
            pointer.SetActive(true);
            NextWaveMess.GetComponent<Text>().enabled = true;
            NextWaveMess.text = "Return to Spawn \n To Begin Next Wave";

        }
        if (currentWave == 2.5)
        {
            pointer.SetActive(true);
            NextWaveMess.GetComponent<Text>().enabled = true;
            NextWaveMess.text = "Return to Spawn \n To Begin Next Wave";

        }
        if (currentWave == 3.5)
        {
            pointer.SetActive(true);
            NextWaveMess.GetComponent<Text>().enabled = true;
            NextWaveMess.text = "Return to Spawn \n To Begin Next Wave";

        }
        if (currentWave == 1)
        {
            //BossPointer.SetActive(false);
            pointer.SetActive(false);
            NextWaveMess.GetComponent<Text>().enabled = false;

        }
        if (currentWave == 2)
        {
            pointer.SetActive(false);
            NextWaveMess.GetComponent<Text>().enabled = false;

        }
        if (currentWave == 3)
        {
            pointer.SetActive(false);
            NextWaveMess.GetComponent<Text>().enabled = false;

        }
        if (currentWave == 4)
        {
           // Bosstarg = GameObject.Find("Flag Ship").transform.position;
            pointer.SetActive(false);
            //BossPointer.SetActive(true);
            NextWaveMess.GetComponent<Text>().enabled = false;

        }

        

        if (currentWave == 1 && countdown1 > 0)
        {
            countdown1 -= Time.deltaTime;

            if (countdown1 < 0.1)
            {
                Debug.Log("get back in postion ready for thew next wave");


                currentWave = 1.5f;
  

            }
        }

        if(Wave2Ready == true && currentWave == 1.5f)
        {
            Wave2.SetActive(true);
            currentWave = 2;
                
        }

        if (currentWave == 2 && countdown2 > 0)
        {
            countdown2 -= Time.deltaTime;

            if (countdown2 < 0.1)
            {
                Debug.Log("get back in postion ready for thew next wave");
                currentWave = 2.5f;

            }
        }


        if (Wave3Ready == true && currentWave == 2.5f)
        {
            Wave3.SetActive(true);
            currentWave = 3;

        }

        if (currentWave == 3 && countdown3 > 0)
        {
            countdown3 -= Time.deltaTime;

            if (countdown3 < 0.1)
            {
                Debug.Log("get back in postion ready for the FlagShip");
                currentWave = 3.5f;

            }
        }

        if (WaveBossReady == true && currentWave == 3.5f)
        {
            WaveBoss.SetActive(true);
            currentWave = 4;

        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6 && currentWave == 1.5f)
        {
            Wave2Ready = true;
        }
        else if (collision.gameObject.layer == 6 && currentWave == 2.5f)
        {
            Wave3Ready = true;
        }
        else if (collision.gameObject.layer == 6 && currentWave == 3.5f)
        {
            WaveBossReady = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {



        if (collision.gameObject.layer == 6 && currentWave == 1.5f)
        {
            Wave2Ready = true;
        }
        else if (collision.gameObject.layer == 6 && currentWave == 2.5f)
        {
            Wave3Ready = true;
        }
        else if (collision.gameObject.layer == 6 && currentWave == 3.5f)
        {
            WaveBossReady = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        Wave2Ready = false;
        Wave3Ready = false;
        WaveBossReady = false;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Wave2Ready = false;
        Wave3Ready = false;
        WaveBossReady = false;
    }
}
