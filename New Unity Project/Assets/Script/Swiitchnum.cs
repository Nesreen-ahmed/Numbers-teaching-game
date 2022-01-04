using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swiitchnum : MonoBehaviour
{
    public GameObject object1, object2;
    public GameObject[] background;
    int index;

    void Start()
    {
        index = 0;
      
    }


    void Update()
    {
        if (index >= background.Length-1)
        {
    
            index = background.Length-1;
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
            object1.SetActive(false);
            object2.SetActive(true);
        }
        Debug.Log(index);
    }

    public void Previous()
    {
       

        for (int i = 0; i < background.Length; i++)
        {
           background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }


}