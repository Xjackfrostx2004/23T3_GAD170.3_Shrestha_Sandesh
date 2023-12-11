using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public int numberOfCubes = 5; // Adjusts the number of cubes  to spawn
    public Vector3[] spawnPositions; // Array of spawn positions

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            SpawnCubes();
        }
    }

    void SpawnCubes()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            
            Vector3 spawnPosition = (i < spawnPositions.Length) ? spawnPositions[i] : Vector3.zero;

            // Instantiates a cube at the desired position
            Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
