using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour
{
    // when the character collides with this object 
    //we restart the scene!
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") == true) 
        {
            //we restart the game
            SceneManager.LoadScene(1);
        }

    }






}
