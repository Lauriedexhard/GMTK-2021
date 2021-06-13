using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public Button StartBut;
    public Button Next;
    public Button Skip;

    public SpriteRenderer Image;

    public Sprite intro1;
    public Sprite intro2;
    public Sprite intro3;
    public Sprite intro4;
    public Sprite intro5;
    public Sprite intro6;
    public Sprite intro7;
    public Sprite intro8;
    public Sprite intro9;
    public Sprite intro10;

    public Vector3 Nexttarg;

    public float page;
    // Start is called before the first frame update
    void Start()
    {
        StartBut.onClick.AddListener(TaskOnClick);
        Next.onClick.AddListener(TaskOnClick2);
        Skip.onClick.AddListener(TaskOnClick3);
    }

    // Update is called once per frame
    void Update()
    {
        if(page == 2)
        {

        }
    }
    void TaskOnClick()
    {
        if(page == 1)
        {
            Image.sprite = intro2;
            StartBut.gameObject.SetActive(false);
            page = 2;
        }



    }

    void TaskOnClick2()
    {
        if (page == 2)
        {
            Image.sprite = intro3;
           
            page = 3;
        }
        else if (page == 3)
        {
            Image.sprite = intro4;
            page = 4;
        }
        else if (page == 4)
        {
            Image.sprite = intro5;
            page = 5;
        }
        else if (page == 5)
        {
            Image.sprite = intro6;
            page = 6;
        }
        else if (page == 6)
        {
            Image.sprite = intro7;
            page = 7;
        }
        else if (page == 7)
        {
            Image.sprite = intro8;
            page = 8;
        }
        else if (page == 8)
        {
            Image.sprite = intro9;
            page = 9;
        }
        else if (page == 9)
        {
            Image.sprite = intro10;
            page = 10;
        }
        else if (page == 10)
        {
            SceneManager.LoadScene(1);
        }
    }

    void TaskOnClick3()
    {
        if (page > 1)
        {
            SceneManager.LoadScene(1);
        }
      
    }

}
