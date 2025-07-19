using System;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public Boolean isBirdAlive = true;

    public GameObject wingUp;
    public GameObject wingDown;

    public float flapDisplayTime = 0.15f;

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
            Flap();
            myRigidBody.linearVelocity = Vector2.up * flapStrength;

        }

        offScreen();
    }

    void Flap()
    {
        StartCoroutine(ShowWingUpThenDown());
    }
     System.Collections.IEnumerator ShowWingUpThenDown()
    {
        wingUp.SetActive(true);
        wingDown.SetActive(false);

        yield return new WaitForSeconds(flapDisplayTime);

        wingUp.SetActive(false);
        wingDown.SetActive(true);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isBirdAlive = false;
    }

    void offScreen()
    {
        if (myRigidBody.transform.position.y < -13 || myRigidBody.transform.position.y > 13)
        {
        logic.gameOver();
        isBirdAlive = false;
        }
    }
}
