using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneArmy : MonoBehaviour
{
    public GameObject army;
    public float armyTime;
    float timer;

    void Start()
    {
        timer = armyTime;
    }

    void Update()
    {
        if (timer > armyTime)
        {
            GameObject tmpArmy = Instantiate(army, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
