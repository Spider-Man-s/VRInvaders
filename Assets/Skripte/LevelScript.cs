using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerUIManager : MonoBehaviour
{

    [SerializeField] private Text playerNameText;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text timerText;


    private Slider hpSlider;
    private float maxHP = 100f;
    private float currentHP = 100f;

    [SerializeField] private float timerDuration = 180f; // 3 minutes

    public Coroutine timerCoroutine;

    public void Start()
    {
        // Example: If you have a static class with a "playerName" variable
        // If your GameSettings is different, just tweak accordingly.
        playerNameText.text = "Player: " + GameSettings.Username;

        scoreText.text = "Score: " + GameSettings.Score.ToString();
        // If you also store wave info in GameSettings or some other manager
        // waveText.text = "Wave: " + GameSettings.currentWave;

        // Start the 3-minute countdown timer


        //timerCoroutine = StartCoroutine(TimerCoroutine(timerDuration));


        // Initialize HP bar
        if (hpSlider != null)
        {
            hpSlider.minValue = 0;
            hpSlider.maxValue = maxHP;
            hpSlider.value = currentHP;
        }
    }

    public void Update()
    {
        // EXAMPLE: If wave count changes in real-time, update wave text
        // waveText.text = "Wave: " + GameSettings.currentWave;

        // EXAMPLE: If you track current HP in real-time from somewhere,
        // you can update the HP bar:
        if (hpSlider != null)
        {
            hpSlider.value = currentHP;
        }
    }

    /// <summary>
    /// Example of taking damage; you can call this from any script
    /// or via GameSettings, etc.
    /// </summary>
    public void TakeDamage(float amount)
    {
        currentHP -= amount;
        if (currentHP < 0) currentHP = 0;
    }

    /// <summary>
    /// Example coroutine that counts down from 'time' to 0,
    /// updating a UI Text each frame.
    /// </summary>
    public IEnumerator TimerCoroutine(float time)
    {
        float countdown = time;
        while (countdown > 0)
        {
            countdown -= Time.deltaTime;
            UpdateTimerDisplay(countdown);
            yield return null;
        }
        // Ensure it ends at 00:00
        UpdateTimerDisplay(0);

        // Do something when the timer hits 0, if needed (e.g., end wave, etc.)
        Debug.Log("Timer Finished!");
    }

    /// <summary>
    /// Formats and updates the Timer text (mm:ss).
    /// </summary>
    private void UpdateTimerDisplay(float timeRemaining)
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
