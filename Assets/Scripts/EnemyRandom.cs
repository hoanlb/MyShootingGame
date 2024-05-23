using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandom : MonoBehaviour
{
    public GameObject army;
    public float maxTime;
    float timer;

    private void Start()
    {
        timer = maxTime;
    }

    private void Update()
    {
        int min = -8;
        int max = 8;
        if (timer > maxTime)
        {
            GameObject tmp = Instantiate(army, new Vector3(Random.Range(min, max), 8, 0), Quaternion.identity);

            /*Destroy(tmp, 10f);*/

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
