using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameShot : MonoBehaviour
{
    public float speed = 50f;
    public Rigidbody2D rb;
    [FMODUnity.EventRef]
    public string sound = "";

    private void Start()
    {
        rb.velocity = transform.right * speed;
        FMODUnity.RuntimeManager.PlayOneShot(sound);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Enemy")
            collision.collider.gameObject.SetActive(false);
    }
}
