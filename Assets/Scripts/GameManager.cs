using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public bool isStartGame;
    public bool isPauseGame;
    public bool isEndGame;
    public int score;
    
    public BirdController bird;
    
    private int collisionCount = 0;
    private void Start()
    {
        Instance = this;
        isStartGame =false;
        isPauseGame = false;
    }
    public void StartGame()
    {
        bird.StartGame();
        isStartGame = true;
    }

    public void PauseGame()
    {
        if(isPauseGame==false)
        {
            Pasue();
        }
        else
        {
            Resume();
        }
    }

    protected void Pasue()
    {
        isPauseGame = true;
        Time.timeScale = 0;
       // AudioManager.Instance.PauseAudio();
    }
    protected void Resume()
    {
        isPauseGame = false;
        Time.timeScale = 1;
    }
    public void EndGame()
    {
        if(collisionCount==0)
        {
            isEndGame = true;
            AudioManager.Instance.PlayEndGameAudio();
            UIManager.Instance.LostGame();
        }
        collisionCount++;
    }

    public void AddScore()
    {
        score++;
        UIManager.Instance.UpdateScore(score);
        AudioManager.Instance.PlayScoreAudio();
    }
}
