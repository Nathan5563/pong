using UnityEngine;
using TMPro;

public class AScoreUpdate : MonoBehaviour
{
    public TMP_Text aiScore;
    public Goal goalScript;

    // Start is called before the first frame update
    void Start()
    {
        aiScore = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        aiScore.text = goalScript.ascore.ToString();
    }
}
