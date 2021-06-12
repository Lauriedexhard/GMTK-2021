using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawn : MonoBehaviour
{
    public GameObject ShipPRFab;
    public GameObject SpawnerLoc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnerLoc.name == "Basic Ship Spawner")
        {
            if (Input.GetKeyDown("k"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
        }

        if (SpawnerLoc.name == "4Gun Ship Spawner")
        {
            if (Input.GetKeyDown("l"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
        }
        if (SpawnerLoc.name == "Rocket Ship Spawner")
        {
            if (Input.GetKeyDown("j"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
        }
        if (SpawnerLoc.name == "Gen Ship Spawner")
        {
            if (Input.GetKeyDown("h"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
        }
        if (SpawnerLoc.name == "Thrust Ship Spawner")
        {
            if (Input.GetKeyDown("g"))
            {
                Instantiate(ShipPRFab, SpawnerLoc.transform.position, Quaternion.identity);
            }
        }

    }
}
