using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Dreamteck.Splines;
using BNG;
public class MonsterSpawner : MonoBehaviour
{
    public GameObject[] monsterPrefabs;
    public Transform spawnPoint;
    public UnityEngine.UI.Slider playerHpBar;


    public SplineComputer[] splineComputers;

    private SplineFollower follower;



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
}