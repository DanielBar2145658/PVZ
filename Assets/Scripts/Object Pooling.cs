using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{



    public static ObjectPooling objectPooling;

    public GameObject[] objectToBePooled;

    public List<GameObject> pool;



    public int amount = 100;


    private void Awake()
    {
        objectPooling = this;
    }

    // Start is called before the first frame update
    void Start()
    {



        for (int i = 0; i < amount; i++) 
        {
            int range = Random.Range(0, 3);

            GameObject t = Instantiate(objectToBePooled[range]);

            t.SetActive(false);

            pool.Add(t);


        
        }




    }

    // Update is called once per frame
    void Update()
    {

    }


    public GameObject GetPool(int i)
    {

        if (!pool[i].activeInHierarchy)
        { 
            return pool[i];
            
        }
            
        
        
        
        return null;


}
}
