using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    private GameObject Player;
    bool isAlive, isUi;
    public AudioSource Death;

    private void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if(Player)
        {
            isAlive = true;
            isUi = false;
        }
        if(!Player && isUi)
        {
            isUi=true;
            Death.volume = 0.3f;
            Death.Play();

        }
    }
}
