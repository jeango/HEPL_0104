
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GameManager.score.ToString();
        highScoreText.text = GameManager.hiScore.ToString();
    }
}
