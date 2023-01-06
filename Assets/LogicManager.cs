using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOver;

    [ContextMenu("IncreaseScore")]
    public void AddScore(int increment)
    {
        playerScore += increment;
        scoreText.text = playerScore.ToString();
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
    }
}
