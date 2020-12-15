using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float Speed;
    Transform Target;
    GameObject playerObject;
    Rigidbody Rig;

    void Start()
    {
        playerObject = GameObject.Find("Player");
        Target = playerObject.transform;
        Rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 Pos = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
        Rig.MovePosition(Pos);
        transform.LookAt(Target);
    }
}
