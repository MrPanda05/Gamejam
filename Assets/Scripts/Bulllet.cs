using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulllet : MonoBehaviour
{
    public float Delay;

    public Value Dps;
    public Value DeathValue;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Debug.Log("qissopoora");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Debug.Log("qissopoora");
        }
    }

    private void Start()
    {
        StartCoroutine(DeathDelay(Delay));

    }

    private void Update()
    {
    }

    
    IEnumerator DeathDelay(float Delay)
    {
        yield return new WaitForSeconds(Delay);
        Destroy(gameObject);
    }
}
