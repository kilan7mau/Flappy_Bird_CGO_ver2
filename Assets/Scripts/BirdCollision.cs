
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CheckDie(collision);
       // CheckScore(collision);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CheckScore(collision);
    }
    protected void CheckDie(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            Debug.Log("Die");
            GameManager.Instance.EndGame();
        }
    }
    private void CheckScore(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("ScoreDetection"))
        {
            Debug.Log("Score");
            GameManager.Instance.AddScore();
        }
    }
}
