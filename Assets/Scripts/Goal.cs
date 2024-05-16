using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public GameObject ballPrefab;
    public Text player1Score;
    public Text player2Score;

    void OnTriggerEnter2D(Collider2D collision)
    {
        checkScore();
        spawnBall();
    }

    void spawnBall()
    {
        Instantiate(ballPrefab, new Vector3(0, 0, 0), transform.rotation);
    }
    void checkScore()
    {
        if (transform.position.x < 0)
        {
            player2Score.text = (int.Parse(player2Score.text) + 1).ToString();
        }

        if (transform.position.x > 0)
        {
            player1Score.text = (int.Parse(player1Score.text) + 1).ToString();
        }
    }
}
