using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    public static bool onFire;
    public Sprite fireSprite;
    public Sprite regularSprite;
    SpriteRenderer player;
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
        if (onFire)
        {
            player.sprite = fireSprite;
            onFire = false;
        }

        else {
            onFire = true;
            player.sprite = regularSprite;
        }
            
    }
}
