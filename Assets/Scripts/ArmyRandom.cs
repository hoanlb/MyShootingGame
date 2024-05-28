using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyRandom : MonoBehaviour
{
    public GameObject army;
    public float randomTime;
    float timer;

    private void Start()
    {
        timer = randomTime;
    }

    private void Update()
    {
        int min = -8;
        int max = 8;
        if (timer > randomTime)
        {
            GameObject tmpPlaneArmy = Instantiate(army, new Vector3(Random.Range(min, max), 3, 0), Quaternion.identity);
            Destroy(tmpPlaneArmy, 20f);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
