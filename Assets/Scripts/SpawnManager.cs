using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public int animalIndex;
    private float spawnRangeX = 20f;
    private float spawnRangeZ;

    [SerializeField, Range(2, 5)]
    private float starDelay = 2f;
    [SerializeField, Range(0.1f, 3f)]
    private float spawInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnRangeZ = transform.position.z;
        InvokeRepeating("SpawnRandomAnimal", starDelay, spawInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void SpawnRandomAnimal()
    {
        float xRand = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawPos = new Vector3(xRand, 0, spawnRangeZ);
        animalIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[animalIndex], spawPos, enemies[animalIndex].transform.rotation);
    }
}
