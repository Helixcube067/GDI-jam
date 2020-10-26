using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCase : MonoBehaviour
{
    public SceneMovement sceneMover;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player") {
            sceneMover.EndGame();
        }
    }
}
