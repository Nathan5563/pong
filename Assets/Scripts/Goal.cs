using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public BoxCollider2D bc2d;
    public BallLaunch launchScript;
    public int pscore = 0;
    public int ascore = 0;

    // Start is called before the first frame update
    void Start()
    {
        bc2d = GetComponent<BoxCollider2D>();
        launchScript = GetComponent<BallLaunch>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("pgoal"))
        {
            pscore++;
            transform.position = Vector3.zero;
            launchScript.Launch(launchScript.speed);
        } else if (collision.CompareTag("aigoal"))
        {
            ascore++;
            transform.position = Vector3.zero;
            launchScript.Launch(launchScript.speed);
        }
    }
}
