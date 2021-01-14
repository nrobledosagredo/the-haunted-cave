using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health;
    public GameObject GC;

    private void Start()
    {
        GC = GameObject.Find("Portal");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Health = Health - 1f;

            if (Health <= 0)
            {
                GC.SendMessage("aumentaKill");
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }

        if (collision.transform.tag == "Bullet2")
        {
            Health = Health - 4f;

            if (Health <= 0)
            {
                GC.SendMessage("aumentaKill");
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
