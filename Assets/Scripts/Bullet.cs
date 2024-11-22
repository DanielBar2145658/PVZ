using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;



    [SerializeField]
    float Speed =15;



    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(Speed,0,0), ForceMode.Force);
    }
}
