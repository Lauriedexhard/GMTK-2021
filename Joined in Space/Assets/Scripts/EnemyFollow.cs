using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float enemySpeed = 10f;

    public bool followmode = false;

    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(followmode == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, enemySpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            followmode = true;
            Target = collision.gameObject;
        }
    }

}
