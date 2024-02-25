using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rbPlayer;
    public float speed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        rbPlayer.velocity = new Vector2(0f, vertical * speed);
    }
}
