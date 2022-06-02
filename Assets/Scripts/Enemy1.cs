using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Enemy1 : MonoBehaviour
{
    public EnemyObjs Stats;

    public Value Dps;//É o mesmo numero de mortes do player;
    private float health, speed, dmg, maxHealth;
    public string animations;
    private Animator anim;
    public AIPath aiPath;
    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play(animations);
        maxHealth = Stats.maxHealth;
        health = Stats.maxHealth;
        dmg = Stats.dmg;
        speed = Stats.speed;
        //Adcionar sprite aki, mudar o scriptable
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        } else if (aiPath.desiredVelocity.x <= 0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bull"))
        {
            Debug.Log($"O seu dano atual é {Dps.Valor} e a vida do Inimigo é {health}");
            health -= Dps.Valor;
            Debug.Log($"A vida do inimigo é {health}");
            //Debug.Log(health);
            //Debug.Log("Q pro!");
            
        }
    }
}
