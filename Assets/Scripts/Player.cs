using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public static Player instance;

    [Header("Variables")]
    [SerializeField]
    private float m_Speed;//Speed
    [SerializeField] internal int life, maxLife;//Current health and max health
    [SerializeField] internal int DeathTimes;
    [SerializeField] internal int numOfSlaves;

    [SerializeField]
    private Rigidbody2D rg;

    [Header("Scripts")]
    public HealthBar healthBar;
    public Value value;
    public Anim anim;

    float yAxis, xAxis;

    public GameObject DeathUi;

    private Vector2 m_Dire;

    private bool isLeft, isRight, isUp, isDown;
    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();

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


    private void Start()
    {
        DeathUi = GameObject.FindGameObjectWithTag("DeathUi");
        healthBar = FindObjectOfType<HealthBar>();
        DeathTimes = value.Valor;
        life = maxLife;
        healthBar.SetMaxHealth(maxLife);
    }
    //Take damage would be healthBar.sethealth()

    private void Update()
    {
        GetInputs();
        if(life <= 0)
        {
            DeathUi.SetActive(true);
            Debug.Log("Morreu kkkkkk");
        }
        ChangeAnim();
    }

    private void FixedUpdate()
    {
        Movement();
    }


    void GetInputs()
    {
         xAxis = Input.GetAxisRaw("Horizontal");
         yAxis = Input.GetAxisRaw("Vertical");

        m_Dire = new Vector2(xAxis, yAxis).normalized;//Make resultant = 1 when walking diagnoly

    }

    void Movement()
    {
        rg.velocity = new Vector2(m_Dire.x * m_Speed, m_Dire.y * m_Speed);
    }

    void ChangeAnim()
    {
        //Right
        if(xAxis > 0 && yAxis == 0)
        {
            isRight = true;
            isLeft = false;
            isUp = false;
            isDown = false;
            anim.ChangeAnimationState("WalkingRight");
        }
        if(isRight && xAxis == 0 && yAxis == 0)
        {
            anim.ChangeAnimationState("IdleRight");
        }
        //Left
        if (xAxis < 0 && yAxis == 0)
        {
            isRight = false;
            isLeft = true;
            isUp = false;
            isDown = false;
            anim.ChangeAnimationState("WalkingLeft");
        }
        if (isLeft && xAxis == 0 && yAxis == 0)
        {

            anim.ChangeAnimationState("IdleLeft");
        }
        //Up
        if (xAxis == 0 && yAxis > 0)
        {
            isRight = false;
            isLeft = false;
            isUp = true;
            isDown = false;
            anim.ChangeAnimationState("WalkingUp");
        }
        if (isUp && xAxis == 0 && yAxis == 0)
        {
            anim.ChangeAnimationState("IdleUp");
        }
        //Down
        if (xAxis == 0 && yAxis < 0)
        {
            isRight = false;
            isLeft = false;
            isUp = false;
            isDown = true;
            anim.ChangeAnimationState("Walking");
        }
        if (isDown && xAxis == 0 && yAxis == 0)
        {
            anim.ChangeAnimationState("Idle");
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        life--;
    //        healthBar.SetHealth(life);
    //        if(life <= 0)
    //        {
    //            value.Valor++;
    //            Destroy(gameObject);
    //            deathPlayer.Play();
    //            //Pausa jogo, e mostra UI para restartar.
    //            //DeathUi.SetActive(true);
    //        }
    //    }
    //}

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            new WaitForSeconds(30f);
            life--;
            healthBar.SetHealth(life);
            if (life <= 0)
            {
                value.Valor++;
                Destroy(gameObject);
                //Pausa jogo, e mostra UI para restartar.
                //DeathUi.SetActive(true);
            }
        }
    }
    
}
