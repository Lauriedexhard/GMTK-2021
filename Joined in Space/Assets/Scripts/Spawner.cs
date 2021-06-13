using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ShipPRFab;
    public GameObject SpawnerLoc;

    bool TimeToSpawn = true;

    public Collider2D WaveOne;
    public Collider2D WaveTwo;
    public Collider2D WaveThree;
    public Collider2D WaveBoss;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnerLoc.tag == "Basic Spawn")
        {
            if (Input.GetKeyDown("k"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
            if (TimeToSpawn == true)
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
                TimeToSpawn = false;
            }
        }

        if (SpawnerLoc.tag == "4Gun Spawm")
        {
            if (Input.GetKeyDown("l"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }

            if (TimeToSpawn == true)
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
                TimeToSpawn = false;
            }
        }

        if (SpawnerLoc.tag == "Rocket Spawn")
        {
            if (Input.GetKeyDown("j"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
            if (TimeToSpawn == true)
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
                TimeToSpawn = false;
            }
        }
        if (SpawnerLoc.tag == "Gen Spawn")
        {
            if (Input.GetKeyDown("h"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
            if (TimeToSpawn == true)
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
                TimeToSpawn = false;
            }
        }
        if (SpawnerLoc.tag == "Thrust Spawn")
        {
            if (Input.GetKeyDown("g"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
            if (TimeToSpawn == true)
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
                TimeToSpawn = false;
            }
        }

        if (SpawnerLoc.tag == "Chase Spawn")
        {
            if (Input.GetKeyDown("m"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
            if (TimeToSpawn == true)
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
                TimeToSpawn = false;
            }
        }

        if (SpawnerLoc.tag == "Truck Spawn")
        {
            if (Input.GetKeyDown(";"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
            if (TimeToSpawn == true)
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
                TimeToSpawn = false;
            }
        }

        if (SpawnerLoc.tag == "ShootShip")
        {
            if (Input.GetKeyDown("'"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
            if (TimeToSpawn == true)
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
                TimeToSpawn = false;
            }
        }

    }
}
