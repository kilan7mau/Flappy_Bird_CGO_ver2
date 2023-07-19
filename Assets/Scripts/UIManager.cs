using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// phari khai báo thư viện này để sử dụng các componet UI
using TMPro;
public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;
    public GameObject btnStartGame;
    public TextMeshProUGUI textScore;
    public GameObject loseGamePanel;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        UpdateScore(0);
    }
    public void StartGameOnClicker()
    {
        GameManager.Instance.StartGame();
        btnStartGame.SetActive(false);
    }

    public void PauseGame()
    {
        GameManager.Instance.PauseGame();
    }
    public void UpdateScore(int score)
    {
        textScore.text = score.ToString();
    }

    public void LostGame()
    {
        loseGamePanel.SetActive(true);
    }
}
