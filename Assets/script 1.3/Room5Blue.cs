﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room5Blue : MonoBehaviour
{

    public GameObject plane1;
    // Start is called before the first frame update
    bool button1 = true;

    void newfunc()
    {
            plane1.SetActive(false);
            //plane9.SetActive(false);
    }

    void OnMouseDown()
    {
        if(button1 == true)
        {
            plane1.SetActive(true);
            button1 = false;
        }
        else if(button1 == false)
        {
            plane1.SetActive(false);
            button1 = true;

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

