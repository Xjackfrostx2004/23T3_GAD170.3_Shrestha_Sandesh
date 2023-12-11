using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepScript : MonoBehaviour
{
    public AudioSource footstepsSound;

    private void Update()
    {
        //plays the walking sound when holding WASD
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footstepsSound.enabled = true;
        }
        else
        {
            //stops the sound when the buttons aren't pressed
            footstepsSound.enabled = false;
        }
    }
}
