using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Commented code: controls the camera
/// This works when colliding with a tagged object. It then reads the tag and then calls one of the appropriate functions. 
/// The functions move the camera in a certain direction based on the players location, offset, and direction. It keeps it at -7Z
/// 
/// non commented code: just follows the players coordinates as it is
/// </summary>
public class CameraController : MonoBehaviour
{
    public Camera cam;
    public GameObject player;
    public int offset = -7;

    private void Update()
    {
        cam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, offset);
    }

    #region saved forgettables
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.gameObject.name);
        if (collision.collider.gameObject.tag == "Right")
            MoveCamRight();
        else if (collision.collider.gameObject.tag == "Left")
            MoveCamLeft();
        else if (collision.collider.gameObject.tag == "Down")
            MoveCamDown();
        else if (collision.collider.gameObject.tag == "Up")
            MoveCamUp();
        else
        {
            MoveCam();
        }
    }

    public void MoveCamRight() {
        cam.transform.position = new Vector3(player.transform.position.x + offset, player.transform.position.y, -7);
    }

    public void MoveCamLeft()
    {
        cam.transform.position = new Vector3(player.transform.position.x - offset, player.transform.position.y, -7);
    }

    public void MoveCamUp()
    {
        cam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + offset, -7);
    }

    public void MoveCamDown()
    {
        cam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - offset, -7);
    }
    */
    #endregion
}
