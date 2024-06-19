using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HadShot : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    private float timer;
    //[SerializeField] private AudioSource shootSoundEffect;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position -  transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }

    void Update()
    {
        timer+= Time.deltaTime;
        if(timer>5)
        {
            Destroy(gameObject);
        }
    }
}
