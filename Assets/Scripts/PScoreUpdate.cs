using UnityEngine;
using TMPro;

public class PScoreUpdate : MonoBehaviour
{
    public TMP_Text playerScore;
    public Goal goalScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        playerScore.text = goalScript.pscore.ToString();
    }
}
