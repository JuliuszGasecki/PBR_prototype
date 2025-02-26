﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hideout : MonoBehaviour
{
    private bool isFree = true;
    [SerializeField]
    private float cooldown;
    [SerializeField]
    private float cooldownTimer = 0.0f;

    private void OnTriggerStay(Collider other)
    {

        if (cooldownTimer <= 0.0f && ((other.tag == "Girl" && Input.GetButton("Fire1")) || (other.tag == "Boi" && Input.GetButton("Fire2"))))
        {
            Hide hide = other.gameObject.GetComponent<Hide>();
            if (hide.IsObjectHidden())
            {
                isFree = true;
                hide.UnhideObject();
                ResetTimer();
            }
            else if (isFree)
            {
                isFree = false;
                hide.HideObject();
                ResetTimer();
            }
        }
        
    }

    private void Update()
    {
        if(cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
        }
    }

    private void ResetTimer()
    {
        cooldownTimer = cooldown;
    }
}
