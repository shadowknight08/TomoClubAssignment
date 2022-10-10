using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool hasObstacle = true;
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        if (hasObstacle)
        {
            Instantiate(obstacle, transform.position + new Vector3(Random.Range(-2,2), 1, 5), Quaternion.identity);
        }
        
    }

   
}
