using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomRandom : MonoBehaviour
{
    public GameObject bom;
    public float randomTime;
    float timer;

    private void Start()
    {
        timer = randomTime;
    }

    private void Update()
    {
        int min = -6;
        int max = 6;
        if (timer > randomTime)
        {
            GameObject tmpPlaneArmy = Instantiate(bom, new Vector3(Random.Range(min, max), 4, 0), Quaternion.identity);
            Destroy(tmpPlaneArmy, 20f);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
