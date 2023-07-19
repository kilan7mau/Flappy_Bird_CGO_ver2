using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonPauseGame : MonoBehaviour
{
    public Image imageButton;
    public Sprite buttonPauseSprite;
    public Sprite buttonResumeSprite;
    void Start()
    {
        imageButton.sprite = buttonPauseSprite;
    }
    public void PauseGameOnClicked()
    {
        UIManager.Instance.PauseGame();
        ChangeButtonImage();
    }
    public void ChangeButtonImage()
    {
        if (GameManager.Instance.isPauseGame )
        {
            imageButton.sprite = buttonResumeSprite;
        }
        else
        {
            imageButton.sprite = buttonPauseSprite;
        }
    }
}
