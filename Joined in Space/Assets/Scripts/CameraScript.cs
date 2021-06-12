using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{



    public GameObject CamTarget;

    public float camSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       // CamTarget = playerShip

        transform.position = new Vector3 (CamTarget.transform.position.x, CamTarget.transform.position.y, -10);


    }
}
