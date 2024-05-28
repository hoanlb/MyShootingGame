using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public GameObject bom;
    public float bomTime;
    float timer;

    void Start()
    {
        timer = bomTime;
    }

    void Update()
    {
        if (timer > bomTime)
        {
            GameObject tmpArmy = Instantiate(bom, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        }
    }
}
