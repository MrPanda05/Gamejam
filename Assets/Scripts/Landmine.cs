using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landmine : MonoBehaviour
{
    public GameObject Explosion;
    public HealthBar healthBar;
    public Player Player;
    private void Update()
    {
        Player = GetComponent<Player>();
        healthBar = GetComponent<HealthBar>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            healthBar.SetHealth(Player.life - 20);
            Explosion.SetActive(true);
            Destroy(gameObject, 0.3f);
        }
    }
}
