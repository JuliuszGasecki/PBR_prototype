﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubbleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }


    void OnTriggerStay(Collider collision)
    {
        if (Input.GetButton("Fire1"))
        {
            string tag = collision.gameObject.tag;
            if (tag.Equals("Girl"))
            {
                RockManager.CanGirlThrow = true;
               // RockManager.CanBoyThrow = false;
            }
            else if (tag.Equals("Boi"))
            {
                //RockManager.CanGirlThrow = false;
                RockManager.CanBoyThrow = true;
            }
        }
    }
}