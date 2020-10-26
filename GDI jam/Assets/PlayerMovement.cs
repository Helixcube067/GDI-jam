using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script controls the movement and animations of the player
/// This gets arrowkey or wasd input information and moves accordingly as well as executes the animation tied to that direction
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D player;
    public float horizontalMove = 0f;
    public Animator playerAnim;
    public float runSpeed = 40f;
    bool jump = false;

    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        player.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }


}
