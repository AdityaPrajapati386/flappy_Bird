using System;
using Unity.Collections;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
    [SerializeField]int upforce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flyingControle();
        
    }

    // Update is called once per frame in physics
    void FixedUpdate()
    {
    
    }

    void flyingControle()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             rigid.linearVelocity=Vector2.up*upforce;
        }
       
    }
}
