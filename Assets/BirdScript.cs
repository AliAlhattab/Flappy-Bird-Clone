using System;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public Boolean isBirdAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isBirdAlive)
        {

            myRigidBody.linearVelocity = Vector2.up * flapStrength;

        }

        offScreen();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isBirdAlive = false;
    }

    void offScreen()
    {
        if (myRigidBody.transform.position.y < -12 || myRigidBody.transform.position.y > 12)
        {
        logic.gameOver();
        isBirdAlive = false;
        }
    }
}
