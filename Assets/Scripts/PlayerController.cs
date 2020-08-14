using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public float speed = 5;

    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
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
}
