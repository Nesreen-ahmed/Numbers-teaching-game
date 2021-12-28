using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchnumexam: MonoBehaviour
{
    public GameObject button1, button2;
    public GameObject[] background;
    int index;

    void Start()
    {
        index = 0;
        // button1 = GameObject.Find("next");
        // button2 = GameObject.Find("learnfinish");
    }


    void Update()
    {
        if (index >= background.Length-1)
        {

            index = background.Length - 1;
        }
        if (index == 0)
        {
            background[0].gameObject.SetActive(true);
        }

    }

    public void Next()
    {
        index += 1;

        for (int i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
        }
        if (index >= background.Length-1)
        {
            button1.SetActive(false);
            button2.SetActive(true);
        }
        Debug.Log(index);
    }

    


}