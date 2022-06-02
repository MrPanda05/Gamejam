using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrophy : MonoBehaviour
{

    public GameObject trophy;
    GameObject Golem;
    // Start is called before the first frame update
    void Start()
    {
        Golem = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if(Golem)
        {
            trophy.SetActive(false);
        }else if(!Golem)
        {
            trophy.SetActive(true);
        }
    }
}
