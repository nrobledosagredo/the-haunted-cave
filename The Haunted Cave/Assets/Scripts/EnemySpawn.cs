using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;

    void Start()
    {
        StartCoroutine(EnemySpawn1());
        StartCoroutine(EnemySpawn2());
    }

    IEnumerator EnemySpawn1()
    {
        while (true)
        {
            GameObject Enemy1 = Instantiate(enemyPrefab1);
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator EnemySpawn2()
    {
        while (true)
        {
            GameObject Enemy2 = Instantiate(enemyPrefab2);
            yield return new WaitForSeconds(5);
        }
    }
}
