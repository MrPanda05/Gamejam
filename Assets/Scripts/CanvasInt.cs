using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasInt : MonoBehaviour
{
    public static CanvasInt instance;

    public GameObject player;
    public GameObject DeathUi;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if(player)
        {
            DeathUi.SetActive(false);
        }
        if(!player)
        {
            DeathUi.SetActive(true);
        }

    }
}
