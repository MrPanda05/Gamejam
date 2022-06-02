using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalShit : MonoBehaviour
{
    private static GlobalShit instance;

    public Player Player;
    
    private void Update()
    {
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }else
        {
            Destroy(gameObject);
        }
    }
}
