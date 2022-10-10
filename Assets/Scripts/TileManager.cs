using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject tilePrefab;
    public float zSpawn = 0;
    public float tileLength = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TileSpawnLoop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTile()
    {
        Instantiate(tilePrefab, transform.forward * zSpawn, transform.rotation);
        zSpawn += tileLength;
    }

    IEnumerator TileSpawnLoop()
    {
        while (true)
        {
            SpawnTile();
            yield return new WaitForSeconds(3);
        }
    }
}
