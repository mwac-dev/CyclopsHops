using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _quitButton;
    public TMP_Text stateText;
    
    public bool GameStarted { get; private set; }
    
    private void Start()
    {
        _startButton.onClick.AddListener(StartGame);
        _quitButton.onClick.AddListener(QuitGame);
    }

    private void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    private void StartGame()
    {
        Debug.Log("Start Game");
        GameStarted = true;
    }
}
