using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody2D rbAI;
    public float speed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
        rbAI = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float direction = ball.transform.position.y > transform.position.y ? 1 : -1;

        float speedMultiplier = Random.value < 0.01f ? Random.Range(0.5f, 1.5f) : 1f;
        rbAI.velocity = new Vector2(0, direction * speed * speedMultiplier);
    }
}
