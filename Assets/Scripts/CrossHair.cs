using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHair : MonoBehaviour
{
    //CrossHair script

    public float speed;
    public GameObject SpearObj;//CrossImage
    //public Vector3 maxP
  



    private void Update()
    {
        MoveSpear();
    }

    //Crosshair
    //Make cursor follow mouse movement
    void MoveSpear()
    {
        
        var mousePos = Input.mousePosition;
        mousePos.z = 10;
        SpearObj.transform.position = Camera.main.ScreenToWorldPoint(mousePos);

    }
}
