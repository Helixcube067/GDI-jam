using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    public GameObject firePrefab;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    private void Shoot()
    {
        Instantiate(firePrefab, firePoint.position, firePoint.rotation);
    }
}
