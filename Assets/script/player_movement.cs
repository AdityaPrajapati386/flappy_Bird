using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

public class player_movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
    [SerializeField]int upforce;
  
    [SerializeField] scoremantener Logic;
//----------------------------------------------------

    [Header("Audio settings")]
    [SerializeField] AudioSource audioSource;   
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip scoreSound;
    [SerializeField] AudioClip gameOverSound;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("logic").GetComponent<scoremantener>();
    }

    // Update is called once per frame
    void Update()
    {
        flyingControle();
        
    }
    void flyingControle()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(jumpSound);
             rigid.linearVelocity=Vector2.up*upforce;
        }   
    }

       void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(gameOverSound);       
        Logic.Gameend();
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(scoreSound);       
        Logic.AddScore();
    }
}
