using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBomRandom : MonoBehaviour
{
    public GameObject planeBom;
    public float planeBomTime;
    float timer;

    private void Start()
    {
        timer = planeBomTime;
    }

    private void Update()
    {
        if (timer > planeBomTime)
        {
            GameObject tmpPlaneBom = Instantiate(planeBom, new Vector3(11, 4, 0), Quaternion.identity);
            Destroy(tmpPlaneBom, 20f);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
