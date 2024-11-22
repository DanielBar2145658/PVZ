using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField]
    Transform[] Lanes;

    bool zombieSpawned;

    int spawnRate = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(zombieSpawned == false) 
            StartCoroutine(SpawnZombie());    
    }



    IEnumerator SpawnZombie()
    {
        zombieSpawned = true;
        yield return new WaitForSeconds(spawnRate);
        zombieSpawned = false;
        int go = Random.Range(0, 99);
        GameObject zombie = ObjectPooling.objectPooling.GetPool(go);
        int range = Random.Range(0, 5);
        if (zombie != null) 
        {
            zombie.transform.position = Lanes[range].position;
            zombie.SetActive(true);


        }



    
    
    }


}
