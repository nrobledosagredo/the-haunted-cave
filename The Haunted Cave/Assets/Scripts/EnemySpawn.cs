using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public Text miTexto;
    public Text KillTxt;
    //public int waveNumber;
    public float timer;
    public float delay;
    public int n;
    public int kills;
    public int waveCont;
    public int m;

    void Start()
    {
        //StartCoroutine(EnemySpawn1());
        //StartCoroutine(EnemySpawn2());
        miTexto.text = "¿Ready?";
        timer = 3.0f;
        delay = 1.0f;
        n = 10;
        m = 5;
        kills = 0;
        waveCont = 1;
    }

    IEnumerator EnemySpawn1()
    {
        for (int i = 0; i < n; i++)
        {
            GameObject Enemy1 = Instantiate(enemyPrefab1);
            yield return new WaitForSeconds(1.2f);
        }
    }

    IEnumerator EnemySpawn2()
    {
        for (int j = 0; j < m; j++)
        {
            GameObject Enemy2 = Instantiate(enemyPrefab2);
            yield return new WaitForSeconds(2.0f);
        }
    }
    private void Update()
    {
        KillTxt.text = "Kills : " + kills.ToString();
        if (kills == 0)
        {

            if (timer <= 0f && waveCont == 1)
            {
                miTexto.text = "Wave : 1";
                timer = 3.4f;
                StartCoroutine(EnemySpawn1());
                waveCont = 2;
            }
            else if (timer >= 0.0f && waveCont == 1)
            {
                timer = timer - delay * Time.deltaTime;
            }

        }
        if (kills == 10 && waveCont == 2)
        {
            if (timer <= 0f)
            {
                miTexto.text = "Wave : 2";
                timer = 3.4f;
                n = 15;
                m = 8;
                waveCont = 3;
                StartCoroutine(EnemySpawn1());
                StartCoroutine(EnemySpawn2());

            }
            else if (timer >= 0.0f && waveCont == 2)
            {
                timer = timer - delay * Time.deltaTime;
            }


        }
        if (kills == 33 && waveCont == 3)
        {
            if (timer <= 0f)
            {
                miTexto.text = "Wave : 3";
                timer = 3.4f;
                n = 21;
                m = 13;
                waveCont = 4;
                StartCoroutine(EnemySpawn1());
                StartCoroutine(EnemySpawn2());

            }
            else if (timer >= 0.0f && waveCont == 3)
            {
                timer = timer - delay * Time.deltaTime;
            }


        }
        if (kills == 67 && waveCont == 4)
        {
            if (timer <= 0f)
            {
                miTexto.text = "Raid Boss";
                timer = 3.4f;
                n = 21;
                m = 13;
                //StartCoroutine(EnemySpawn1());
                //StartCoroutine(EnemySpawn2());
                //Aqui se Spawnea el Boss

            }
            else if (timer >= 0.0f && waveCont == 4)
            {
                timer = timer - delay * Time.deltaTime;
            }


        }
    }
    public void aumentaKill()
    {
        kills = kills + 1;
    }
}
