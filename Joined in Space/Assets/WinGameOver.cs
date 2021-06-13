using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinGameOver : MonoBehaviour
{

    static public bool Gameover;

    static public bool youwin;

    public Text Finish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(youwin == true)
        {
            Finish.GetComponent<Text>().enabled = true;
            Finish.text = "YOU WIN! \n press enter to restart";
            if(Input.GetKeyDown(KeyCode.Return))
            {
                youwin = false;
                Gameover = false;
                SceneManager.LoadScene(0);
            }
        }
        if(Gameover == true)
        {
            Finish.GetComponent<Text>().enabled = true;
            Finish.text = "You Loose \n press enter to restart";
            if (Input.GetKeyDown(KeyCode.Return))
            {
                youwin = false;
                Gameover = false;
                SceneManager.LoadScene(0);
            }
        }
    }
}
