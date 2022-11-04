using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class movement1 : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public int speed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0f);
    }
}
