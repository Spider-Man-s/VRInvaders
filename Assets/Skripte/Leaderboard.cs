using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class Leaderboard : MonoBehaviour
{

    [SerializeField] Text board;
    [SerializeField] Text title;
    [SerializeField] GameObject[] hideThis;

    private string leaderboardFilePath;
    void Start()
    {
        leaderboardFilePath = Path.Combine(Application.dataPath, "Leaderboard", "LeaderboardStats.txt");

    }

    public void DisplayLeaderboard()
    {
        title.text = "Leaders";
        foreach (GameObject hide in hideThis)
        {
            hide.SetActive(false);
        }

        if (File.Exists(leaderboardFilePath))
        {
            string[] existingEntries = File.ReadAllLines(leaderboardFilePath);
            List<string> formattedEntries = new List<string>();

            int rank = 1;
            foreach (string entry in existingEntries)
            {
                string[] entryParts = entry.Split(':');

                if (entryParts.Length == 2)
                {
                    string username = entryParts[0].Trim();
                    string scoreStr = entryParts[1].Replace(";", "").Trim();

                    if (int.TryParse(scoreStr, out int score) && score > 0)
                    {
                        string formattedEntry = $"{rank}. {username} ..... {score}";
                        formattedEntries.Add(formattedEntry);
                        rank++;
                    }
                }
            }


            board.text = string.Join("\n", formattedEntries);
        }
        else
        {
            board.text = "No leaderboard data available.";
        }
    }

    public void goBack()
    {
        title.text = "VRInvaders";
        foreach (GameObject hide in hideThis)
        {
            hide.SetActive(true);
        }
    }

}
