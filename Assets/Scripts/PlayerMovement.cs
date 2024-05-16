using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform paddle;
    public string upKey;
    public string downKey;
    public float movespeed;

    // Update is called once per frame
    void Update()
    {
        bool isPressingUp = Input.GetKey(upKey);
        bool isPressingDown = Input.GetKey(downKey);

        if (isPressingUp && paddle.position.y < 3.5)
        {
            paddle.Translate(Vector2.up * Time.deltaTime * movespeed);
        }

        if (isPressingDown && paddle.position.y > -3.5)
        {
            paddle.Translate(Vector2.down * Time.deltaTime * movespeed);
        }
    }
}
