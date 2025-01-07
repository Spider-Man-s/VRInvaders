using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerUIManager : MonoBehaviour
{

    [SerializeField] private Text playerNameText;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text timerText;


    private Slider hpSlider;
    private float maxHP = 100f;
    private float currentHP = 100f;


    private Scene currentScene;
    public Coroutine timerCoroutine;

    public void StartUI()
    {

        playerNameText.text = "Player: " + GameSettings.Username;
        scoreText.text = "Score: " + GameSettings.Score.ToString();
        currentScene = SceneManager.GetActiveScene();

        if (GameSettings.currentDifficulty == GameSettings.Difficulty.Easy)
        {
            timerCoroutine = StartCoroutine(TimerCoroutine(60f));
        }
        else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Medium)
        {
            timerCoroutine = StartCoroutine(TimerCoroutine(120f));
        }
        else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Hard)
        {
            timerCoroutine = StartCoroutine(TimerCoroutine(180f));
        }

    }

    public void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + GameSettings.Score.ToString();
        }

    }


    public IEnumerator TimerCoroutine(float time)
    {
        float countdown = time;
        while (countdown > 0)
        {
            countdown -= Time.deltaTime;
            UpdateTimerDisplay(countdown);
            yield return null;
        }

        UpdateTimerDisplay(0);
        if (currentScene.name == "FirstLevel")
        {
            SceneManager.LoadScene("SecondLevel", LoadSceneMode.Single);
        }
        else if (currentScene.name == "SecondLevel")
        {
            SceneManager.LoadScene("ThirdLevel", LoadSceneMode.Single);
        }
        else if (currentScene.name == "ThirdLevel")
        {
            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
        }

    }
    private void UpdateTimerDisplay(float timeRemaining)
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
