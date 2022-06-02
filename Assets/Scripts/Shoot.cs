using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //Shoot in for directions left right up and down
    //What if the player holds to button at the same time?
    //It could either switch to the new input or stay the same, but not shoot at the same time on both
    //It will come out of the end of the wand

    public AudioSource Bullet;
    internal bool up, down, left, right;
    private bool canShoot = true;
    [Header("Values")]
    [SerializeField]private float delay, value;
    [SerializeField]private Rigidbody2D bullet;
    [SerializeField] private float force;
    [SerializeField] private List<Transform> Places;

    private void Start()
    {
    }

    private void Update()
    {
        GetInput();
        if(up)
        {
            if(canShoot)
            {
                Shooter(new Vector3(0,1,0), Places[1]);
                canShoot = false;
                Bullet.volume = 0.3f;
                Bullet.Play();
                StartCoroutine(ShootDelay());
            }
        }
        if (down)
        {
            if (canShoot)
            {
                Shooter(new Vector3(0, -1, 0), Places[0]);
                canShoot = false;
                Bullet.volume = 0.3f;
                Bullet.Play();
                StartCoroutine(ShootDelay());
            }
        }
        if (left)
        {
            if (canShoot)
            {
                Shooter(new Vector3(-1, 0, 0), Places[3]);
                canShoot = false;
                Bullet.volume = 0.3f;
                Bullet.Play();
                StartCoroutine(ShootDelay());
            }
        }
        if (right)
        {
            if (canShoot)
            {
                Shooter(new Vector3(1, 0, 0), Places[2]);
                canShoot = false;
                Bullet.volume = 0.3f;
                Bullet.Play();
                StartCoroutine(ShootDelay());
            }
        }

    }
    void GetInput()
    {
        up = Input.GetKey(KeyCode.UpArrow);
        down = Input.GetKey(KeyCode.DownArrow);
        left = Input.GetKey(KeyCode.LeftArrow);
        right = Input.GetKey(KeyCode.RightArrow);
        
    }

    void Shooter(Vector3 direction, Transform barrel)
    {
        var newBullet = Instantiate(bullet, barrel.position, transform.rotation);
        newBullet.velocity = direction * force;
    }
    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(delay);
        canShoot = true;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.CompareTag("Enemy"))
    //    {
            
    //    }
    //}

}
