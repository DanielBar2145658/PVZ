using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    [SerializeField]
    ZombiesSO zombiesSO;


    int currentHealth;

    public float speed;

    [SerializeField]
    Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = zombiesSO.GetMaxHealth();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth == 0) 
        {

            Gamemanager.Instance.Sun += zombiesSO.GetSunAmount();
            Gamemanager.Instance.ui.UpdateText();
            currentHealth = zombiesSO.GetMaxHealth();
            gameObject.SetActive(false);

        
        
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(-zombiesSO.GetSpeed(), 0, 0), ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet") == true) 
        {
            currentHealth--;
        
        }
    }

}
