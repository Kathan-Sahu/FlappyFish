using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject GameMenu;
    public GameObject GameOverMenu;
    [SerializeField] TextMeshProUGUI textScore;
    int score;
    ScoreManager scoreManager;
    void Awake()
    {
        scoreManager = FindObjectOfType<ScoreManager>();   
    }
    // Start is called before the first frame update
    void Start()
    {
        textScore.SetText("Score : 0");
    }

    // Update is called once per frame
    void Update()
    {
        score = scoreManager.GetScore();
        textScore.SetText("Score : " + score);
    }
    public void PauseButton()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        GameMenu.SetActive(false);
    }
    public void PlayButton()
    {
        Time.timeScale = 1;
        GameMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void GameOverUI()
    {
        GameOverMenu.SetActive(true);
        Time.timeScale = 0;
        GameMenu.SetActive(false);
        
    }
    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void MainGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
