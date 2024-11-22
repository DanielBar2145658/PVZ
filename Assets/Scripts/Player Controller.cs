using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    Rigidbody rb;


    [SerializeField]
    GameObject bullet;

    [SerializeField]
    float speed;


    [SerializeField]
    Transform[] lanes;



    public Transform shootPoint;

    int currentlane;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        Shoot();


    }


    void Move() 
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            if (currentlane != 4)
            {
                currentlane++;

            }

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentlane != 0) 
            {
                currentlane--;

            }


        }
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, lanes[currentlane].position.z);



    }


    void Shoot() 
    {

        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Instantiate(bullet, shootPoint);

        }

        
    
    
    }
}
