using UnityEngine;

public class BallLaunch : MonoBehaviour
{
    public Rigidbody2D rbBall;
    private float time = 0f;
    public float speed = 20.0f;
    float x;
    float y;

    // Start is called before the first frame update
    void Start()
    {
        rbBall = GetComponent<Rigidbody2D>();

        Launch(speed);
    }

    void FixedUpdate()
    {
        if (time > 6f)
        {
            float speedIncrement = 1.3f;
            rbBall.velocity *= speedIncrement;
            time = 0f;
        }
        time += UnityEngine.Time.deltaTime;
    }

    public void Launch(float speed)
    {
        x = Random.Range(0, 2) == 0 ? -1 : 1;
        y = Random.Range(0, 2) == 0 ? -1 : 1;
        rbBall.velocity = new Vector2(x * speed, y * speed);
    }
}
