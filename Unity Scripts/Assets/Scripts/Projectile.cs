﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float Speed;
    public float TimeOut;
    public GameObject Player;

    public GameObject EnemyDeath;

    public GameObject ProjectileParticle;

    public int PointsForKill;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("Player");
        EnemyDeath = Resources.Load("Prefabs/DeathParticle") as GameObject;

        ProjectileParticle = Resources.Load("Prefabs/RespawnParticle") as GameObject;

        if (Player.transform.localScale.x < 0)
            Speed = -Speed;

        // Speed = Speed * Mathf.Sign(Player.transform.localScale.x);

        // GetComponent<Rigidbody2D>().velocity = new Vector2(Speed + (Player.GetComponent<Rigidbody2D>().velocity.x/3),GetComponent<Rigidbody2D>().velocity.y + (Player.GetComponent<Rigidbody2D>().velocity.y/3));

        // Destroys Projectile after X seconds
        Destroy(gameObject, TimeOut);

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            ScoreManager.AddPoints(PointsForKill);
        }
        void OnCollisionEnter2D(Collision2D other)
        {
            Instantiate(ProjectileParticle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}

