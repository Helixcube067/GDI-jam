using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script controls the movement and animations of the player
/// This gets arrowkey or wasd input information and moves accordingly as well as executes the animation tied to that direction
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed;
    public Animator playerAnim;

    void FixedUpdate()
    {
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            player.MovePosition(new Vector2(player.transform.position.x - speed, player.position.y));
            playerAnim.SetTrigger("Left key");
        }

        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            player.MovePosition(new Vector2(player.transform.position.x + speed, player.position.y));
            playerAnim.SetTrigger("Right key");
        }

        /*else if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            player.MovePosition(new Vector2(player.transform.position.x, player.position.y - speed));
            playerAnim.SetTrigger("Down key");
        }*/

        else if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            player.MovePosition(new Vector2(player.transform.position.x, player.position.y + speed));
            playerAnim.SetTrigger("Up key");
        }
        else {
            playerAnim.SetTrigger("No key");
        }
    }
}
