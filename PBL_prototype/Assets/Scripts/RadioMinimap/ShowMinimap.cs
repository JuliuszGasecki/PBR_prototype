﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMinimap : MonoBehaviour
{
    public GameObject Map;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SetMapActivity();
    }

    void SetMapActivity()
    {

        if (Input.GetButton("Map1") && Input.GetButton("Map2"))
        {
            Map.SetActive(true);
        }

        if (!Input.GetButton("Map1") || !Input.GetButton("Map2"))
        {
            Map.SetActive(false);
        }
    }

}