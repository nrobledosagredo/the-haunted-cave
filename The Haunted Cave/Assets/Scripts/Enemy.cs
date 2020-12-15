using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Health = Health - 1f;

            if(Health <= 0)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
