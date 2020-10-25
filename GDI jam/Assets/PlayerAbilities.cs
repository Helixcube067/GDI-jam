using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    bool onFire;
    Sprite fireSprite;
    Sprite regularSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Switcheroo();
    }

    private void Switcheroo()
    {
        if (onFire) { }
           // onFire = false;
        else
            onFire = true;
    }
}
