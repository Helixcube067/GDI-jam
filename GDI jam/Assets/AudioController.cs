using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AudioController : MonoBehaviour
{
    public AudioSource audioPiece;
    //public TextMeshProUGUI example;

    void Start()
    {
        //example.text = "A nice day to go to the beach eh?";
        audioPiece.PlayDelayed(1f);
    }

    
    void Update()
    {
        
    }
}
