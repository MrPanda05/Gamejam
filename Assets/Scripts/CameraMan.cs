using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour
{
    public static CameraMan instance;
    public Transform player;
    private GameObject ps;
    public Vector3 offset;
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
    void Update()
    {
        ps = GameObject.FindGameObjectWithTag("Player");
        player = ps.transform;
        if(!player)
        {
            return;
        }
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }
}
