using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    //we want to spawn rocks at a random spawn point 
    //whent the player  runs into this trigger area

    //need a reference to the falling rock
    [SerializeField] private GameObject fallingRockPrefab;

    //need a reference to the collision of the player]
    //need a location (i.e reference to the SPAWN POINTS)
    //week 6 in the slides : LISTS
    [SerializeField] private List<GameObject> rockSpawnerPoints = new List<GameObject>();
    [SerializeField] private List  <Rock> rocks = new List<Rock>();

    //need reference to the collision of the player
    private void OnTriggerEnter(Collider other)
    {
        //if the player gets into the trigger
        if (other.CompareTag("Player") == true)
        {
            Debug.Log("Collision");
            // spawn a falling rock at a random spawn point
            Vector3 spawnPosition = rockSpawnerPoints[Random.Range(0, rockSpawnerPoints.Count)].transform.position;

            //CHECK THAT THE VARIABLE IS NOT NULL
            if (fallingRockPrefab != null)
            {
                GameObject newRock = Instantiate(fallingRockPrefab, spawnPosition, Quaternion.identity);
                rocks.Add(newRock.GetComponent<Rock>());

                foreach (Rock rock in rocks)
                {
                    rock.name = "Dingo";
                }
            }
            
        }
    }
}
