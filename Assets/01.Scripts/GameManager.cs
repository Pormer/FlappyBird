using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject basePanel;
    [SerializeField] private TextMeshProUGUI scoreText;

    private int score;

    private void Awake() 
    {
        if(Instance != null) {
            Destroy(gameObject);
        }    
        else {
            Instance = this;
        }
    }

    private void Start() 
    {
        Time.timeScale = 0;
        basePanel.SetActive(true);  
        gameOverPanel.SetActive(false);  
    }

    public void PlayBtnClick() 
    {
        Time.timeScale = 1;
        basePanel.SetActive(false); 
    }

    public void RetryBtnClick() 
    {
        SceneManager.LoadScene(0);
    }

    public void Scoring()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver() 
    {
        gameOverPanel.SetActive(true); 
        Time.timeScale = 0;
    }
}
