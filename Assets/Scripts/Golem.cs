using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : MonoBehaviour
{
    private void Start()
    {
        Golems.transform.localScale = new Vector3(6,6,0);
    }
    public GameObject Golems;
    private void Update()
    {
        Golems.transform.localScale = new Vector3(6, 6, 0);
        if(!Golems)
        {
            return;
        }
        
    }
}
