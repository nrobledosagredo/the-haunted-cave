using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public float Speed = 8f;
    public float lifeDuration = 2f;

    private float lifeTimer;

    void Start()
    {
        lifeTimer = lifeDuration;
    }

    void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;

        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}