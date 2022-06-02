using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Portal : MonoBehaviour
{
    public int sceneID;
    public Value deathTotal;
    public Vector3 SpawnPos;
    public GameObject Player;
    public AudioSource PortalSOund;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync(sceneID);
            PortalSOund.volume = 0.3f;
            PortalSOund.Play();
            Player.transform.position = SpawnPos;

        }
    }
    public void goTo()
    {
        deathTotal.Valor = 0;
        //Player.transform.position = SpawnPos;
        SceneManager.LoadSceneAsync(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
