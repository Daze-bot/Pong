using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingSpeed;
    public float leftDeadZone = -20f;
    public float rightDeadZone = 20f;
    public float spawnDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("LaunchBall", spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftDeadZone || transform.position.x > rightDeadZone)
        {
            Destroy(gameObject);
        }
    }

    void LaunchBall()
    {
        bool isRight = UnityEngine.Random.value >= 0.5;
        float xVelocity = -1f;

        if (isRight)
        {
            xVelocity = 1f;
        }

        float yVelocity = UnityEngine.Random.Range(-1f, 1f);

        rb.velocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed);
    }
}
