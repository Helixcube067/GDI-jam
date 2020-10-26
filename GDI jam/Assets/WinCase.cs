using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinCase : MonoBehaviour
{
    public SceneMovement sceneMover;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI buttonWinText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            sceneMover.EndGame();
            winText.text = "You made it back home!";
            buttonWinText.text = "Play again?";
        }
    }
}
