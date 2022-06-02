using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHere : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = new Vector3(-7.39f,0,0);
        }
    }
}
