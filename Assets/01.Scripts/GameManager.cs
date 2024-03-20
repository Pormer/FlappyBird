using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake() 
    {
        if(Instance != null) {
            Destroy(gameObject);
        }    
        else {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void GameOver() 
    {
        Time.timeScale = 0;
    }
}
