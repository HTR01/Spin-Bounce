using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject bullet;
    int randomNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRandom()
    {
        Instantiate(bullet, new Vector3(Random.Range(-1190, 1190), 750, 0), transform.rotation);


    }
}
