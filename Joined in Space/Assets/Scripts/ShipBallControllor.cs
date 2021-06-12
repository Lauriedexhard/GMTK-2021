using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipBallControllor : MonoBehaviour
{
    public static bool GunReady = false;

    public static float Charge;

    public Text Chargeind;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Charge < 100)
        {
            Charge += Time.deltaTime * 200;
            GunReady = false;
        }

        if(Charge > 100)
        {
            Charge = 100;
        }


        if(Charge > 99)
        {
            GunReady = true;
        }

        Chargeind.text = "Charge: " + Charge;
    }
}
