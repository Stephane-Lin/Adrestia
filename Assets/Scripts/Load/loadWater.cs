﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadWater : MonoBehaviour 
{
    bool load;

    void Start()
    {
        load = false;
    }

    void Update()
    {
        if(load == false)
        {
            load = true;
            SceneManager.LoadScene("Water");
        }
    }
}
