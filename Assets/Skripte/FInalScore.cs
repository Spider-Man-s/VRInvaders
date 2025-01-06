using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class FInalScore : MonoBehaviour
{
    [SerializeField] private Text scoreText;


    private string leaderboardFilePath;

    private void Awake()
    {
        leaderboardFilePath = Path.Combine(Application.dataPath, "Leaderboard", "LeaderboardStats.txt");
    }
    void Start()
    {
        scoreText.text = "Your score: " + GameSettings.Score;
        UpdateExistingScore(GameSettings.Username, GameSettings.Score);
    }

    public void UpdateExistingScore(string username, int newScore)
    {

        string[] existingEntries = File.ReadAllLines(leaderboardFilePath);


        List<string> updatedLines = new List<string>();


        for (int i = 0; i < existingEntries.Length; i++)
        {
            string entry = existingEntries[i];


            if (entry.StartsWith(username + ":"))
            {

                string newLine = $"{username}: {newScore};";
                updatedLines.Add(newLine);

            }
            else
            {

                updatedLines.Add(entry);
            }
        }
        File.WriteAllLines(leaderboardFilePath, updatedLines);
    }
}
