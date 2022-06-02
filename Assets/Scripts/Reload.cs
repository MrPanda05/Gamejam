using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Reload : MonoBehaviour
{
    public GameObject DeathUi;
    public HealthBar healthBar;
    public GameObject player;
    GameObject spawnpoint;
    Player stats;
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //player.SetActive(true);
        player.transform.position = spawnpoint.transform.position;
        healthBar.SetHealth(100);
        DeathUi.SetActive(false);
    }

    private void Update()
    {
        spawnpoint = GameObject.FindGameObjectWithTag("Spawn");
        stats = GetComponent<Player>();
        player = GameObject.FindGameObjectWithTag("Player");
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReloadLevel();
        }
    }
}
