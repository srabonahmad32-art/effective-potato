using UnityEngine;

public class HouseGenerator : MonoBehaviour
{
    public GameObject[] roomPrefabs;
    public int roomCount = 8;

    void Start()
    {
        Vector3 spawnPos = Vector3.zero;

        for (int i = 0; i < roomCount; i++)
        {
            GameObject room = Instantiate(
                roomPrefabs[Random.Range(0, roomPrefabs.Length)],
                spawnPos,
                Quaternion.identity
            );

            spawnPos += new Vector3(15, 0, 0);
        }
    }
}