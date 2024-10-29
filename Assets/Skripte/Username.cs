using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Username : MonoBehaviour
{
    [SerializeField] Text usernameInput;
    [SerializeField] Text descriptionText;

    [SerializeField] Text title;

    [SerializeField] GameObject[] buttons;
    [SerializeField] GameObject[] hideThis;
    private Color defaultDescriptionColor;
    private string leaderboardFilePath;

    void Start()
    {
        defaultDescriptionColor = descriptionText.color;
        leaderboardFilePath = Path.Combine(Application.dataPath, "Leaderboard", "LeaderboardStats.txt");
    }
    public void CheckUsernameInput()
    {
        if (string.IsNullOrEmpty(usernameInput.text))
        {
            descriptionText.text = "Please enter your username to continue";
            descriptionText.color = Color.red;
        }
        else
        {
            title.text = "VRInvaders";
            foreach (GameObject button in buttons)
            {
                button.SetActive(true);
            }

            foreach (GameObject hide in hideThis)
            {
                hide.SetActive(false);
            }
            WriteToLeaderboard(usernameInput.text, 0);
        }
    }

    private void WriteToLeaderboard(string username, int score)
    {

        if (File.Exists(leaderboardFilePath))
        {
            string[] existingEntries = File.ReadAllLines(leaderboardFilePath);
            foreach (string entry in existingEntries)
            {
                if (entry.StartsWith(username + ":"))
                {
                    Debug.Log("Username already exists in the leaderboard.");
                    return;
                }
            }
        }

        string newEntry = $"{username}: {score};\n";
        File.AppendAllText(leaderboardFilePath, newEntry);
        Debug.Log("New username added to the leaderboard.");
    }
}
