using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager Instance { get; private set; }
    public int Insanity;

    public int Sun;


    public UI ui;



    void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);

        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(this);

        ui = FindObjectOfType<UI>();
    }








}
