using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour
{
    public Material[] material;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = material[0];
    }

    // when the character collides with this object 
    //we restart the scene!
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            //we restart the game
            SceneManager.LoadScene(1);
        }

        //changes the material of rock when it hits the ground 
        if (collision.gameObject.CompareTag("Floor") == true)
        {
            rend.sharedMaterial = material[1];
        }
    }
}




   








