using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Dreamteck.Splines;
using BNG;
using UnityEngine.SceneManagement;
public class MonsterSpawner : MonoBehaviour
{
    public GameObject[] monsterPrefabs;
    public Transform spawnPoint;
    public UnityEngine.UI.Slider playerHpBar;
    public SplineComputer[] splineComputers;
    private SplineFollower follower;

    private Coroutine spawnCoroutine;

    private Scene currentScene;

    public void SpawnMonster()
    {
        int randomPrefabIndex = Random.Range(0, monsterPrefabs.Length);
        GameObject monster = Instantiate(monsterPrefabs[randomPrefabIndex], spawnPoint.position, Quaternion.identity);


        HitPlayer hpbar = monster.GetComponent<HitPlayer>();
        follower = monster.GetComponent<SplineFollower>();

        if (hpbar != null)
        {
            hpbar.playerHp = playerHpBar;
        }

        if (follower != null && splineComputers.Length > 0)
        {
            follower.follow = false;
            int randomSplineIndex = Random.Range(0, splineComputers.Length);
            follower.spline = splineComputers[randomSplineIndex];
            follower.RebuildImmediate();
            follower.SetPercent(0.0f);
            follower.follow = true;

        }

    }

    public void SpawnWawe()
    {
        currentScene = SceneManager.GetActiveScene();

        if (GameSettings.currentDifficulty == GameSettings.Difficulty.Easy)
        {
            spawnCoroutine = StartCoroutine(TimerCoroutine(60f, 2, 5f));
        }
        else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Medium)
        {
            spawnCoroutine = StartCoroutine(TimerCoroutine(120f, 3, 3.5f));
        }
        else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Hard)
        {
            spawnCoroutine = StartCoroutine(TimerCoroutine(180f, 4, 2.5f));
        }
    }



    public IEnumerator TimerCoroutine(float time, int monster, float offset)
    {
        float countdown = time;
        while (countdown > 0)
        {
            countdown -= Time.deltaTime;
            for (int i = 0; i < monster; i++)
            {
                SpawnMonster();
                yield return new WaitForSeconds(0.5f);
            }

            yield return new WaitForSeconds(offset);
        }


    }
}