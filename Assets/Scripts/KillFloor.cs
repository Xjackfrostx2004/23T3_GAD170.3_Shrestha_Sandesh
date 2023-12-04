using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillFloor : MonoBehaviour
{
    // When the player falls on this floor the game restarts
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            //load the game scene
            SceneManager.LoadScene(1);

        }
    }
            


}
