using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile; // Assign your ground tile prefab here
    private Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        // Ensure 'Instantiate' is used correctly
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    private void Start()
    {
        // Spawns 15 tiles at the start of the game
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }
    }
}
