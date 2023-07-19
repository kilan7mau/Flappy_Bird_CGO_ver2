using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 1f;
    void Update()
    {
        if (GameManager.Instance.isEndGame) return;
        this.transform.position += Vector3.left * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroy")
        {
            Destroy(gameObject);
        }
    }   
}
