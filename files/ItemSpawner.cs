using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    public Transform[] randomSpawnPoints;
    public Transform bathroomSpawnPoint;

    void Start()
    {
        if (ReferralManager.referralActive)
        {
            SpawnItemsInBathroomOnly();
        }
        else
        {
            SpawnRandomly();
        }
    }

    void SpawnItemsInBathroomOnly()
    {
        foreach (GameObject item in itemPrefabs)
        {
            Instantiate(item, bathroomSpawnPoint.position, Quaternion.identity);
        }
    }

    void SpawnRandomly()
    {
        foreach (GameObject item in itemPrefabs)
        {
            Transform randomPoint = randomSpawnPoints[
                Random.Range(0, randomSpawnPoints.Length)
            ];

            Instantiate(item, randomPoint.position, Quaternion.identity);
        }
    }
}