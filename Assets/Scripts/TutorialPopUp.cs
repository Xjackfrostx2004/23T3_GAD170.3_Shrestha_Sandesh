using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopUp : MonoBehaviour
{
    // Reference to the UI Canvas
    public Canvas Canvas;

    // Reference to the PlayerMovement script
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        // Sets the initial state of the canvas
        if (Canvas != null)
        {
            Canvas.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object is the player
        if (other.CompareTag("Player"))
        {
            // Show pop up when the player enters the trigger
            ShowUI();
        }

        // Stop player movement
        //This is only for the Win Canvas
        StopPlayerMovement();
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the entering object is the player
        if (other.CompareTag("Player"))
        {
            // Hide the pop up when the player exits the trigger
            HideUI();
        }
    }

    // Displays the pop up UI
    private void ShowUI()
    {
        // Check if the reference is not null before trying to access it
        if (Canvas != null)
        {
            Canvas.gameObject.SetActive(true);
        }
    }

    // Hides the pop up UI
    private void HideUI()
    {
        // Check if the reference is not null before trying to access it
        if (Canvas != null)
        {
            Canvas.gameObject.SetActive(false);
        }
    }
    // Stops the player movement by disabling the PlayerMovement script
    //i tried- but this sadly doesnt stop the player movement idk
    private void StopPlayerMovement()
    {
        // Check if the reference is not null before trying to access it
        if (playerMovement != null)
        {
            // Disable the PlayerMovement script
            playerMovement.enabled = false;
        }
    }
}
