using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameShot : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Enemy")
            collision.collider.gameObject.SetActive(false);
    }
}
