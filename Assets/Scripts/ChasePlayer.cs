using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class ChasePlayer : MonoBehaviour
{
    public GameObject player;
    public EnemyObjs Enemy;
    private Transform playerTransform;
    public float speed;

    public AIDestinationSetter ai;

    float detecrangeed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        detecrangeed = Enemy.detectRange;
        playerTransform = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerTransform)
        {
            return;
        }
        if(Vector2.Distance(transform.position, playerTransform.position) < detecrangeed)
        {
            ai.enabled = true;
        }
    }
}
