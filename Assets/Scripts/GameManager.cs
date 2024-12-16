
using UnityEngine;

public class GameManager
{
    public static int score;
    public static int hiScore;

    public static void NewGame()
    {
        LoadHighScore();
        score = 0;
    }

    public static void GameOver()
    {
        Debug.LogFormat("Game Over: score={0}, hiscore={1}", score, hiScore);
        if (score > hiScore)
        {
            hiScore = score;
            SaveHighScore();
        }
    }

    public static void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", hiScore);
    }

    public static void LoadHighScore()
    {
        hiScore = PlayerPrefs.GetInt("HighScore");
    }
}
