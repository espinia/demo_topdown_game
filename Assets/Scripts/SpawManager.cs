using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int animalIndex;
    private float spawnRangeX = 14.0f;
    private float spawnPosZ = 28.0f;

    [SerializeField,Range(2,5)]
    private float startDelay = 2.0f;

    [SerializeField, Range(0.1f, 3)]
    private float spawnInterval = 0.1f;

    //Una lista
    //public List<GameObject> enemies;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosZ = transform.position.z;

        //invoca un método repetidamente después de un delay inicial y cada cierto tiempo
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void SpawnRandomAnimal()
	{
        //posicion donde aparece el enemigo
        float xRand = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(xRand, 0, spawnPosZ);

        animalIndex = Random.Range(0, enemies.Length);

        Instantiate(enemies[animalIndex], spawnPos,
                    enemies[animalIndex].transform.rotation);
    }
}
