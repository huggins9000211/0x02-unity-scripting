﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public int health;
    public float speed = 5;
    private int score;

    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        score = 0;
        rigidbody = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        float Horiz = Input.GetAxis ("Horizontal");
        float Vert = Input.GetAxis ("Vertical");

        Vector3 move = new Vector3(Horiz, 0.0f, Vert);

        rigidbody.AddForce(move * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            score++;
            Debug.Log($"Score: {score}");
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Trap")
        {
            health--;
            Debug.Log($"Health: {health}");
        }
    }
}
