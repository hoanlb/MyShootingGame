using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneArmyRandom : MonoBehaviour
{
    public GameObject planeArmy;
    public float planeArmyTime;
    float timer;

    private void Start()
    {
        timer = planeArmyTime;
    }

    private void Update()
    {
        if (timer > planeArmyTime)
        {
            GameObject tmpPlaneArmy = Instantiate(planeArmy, new Vector3(11, 3, 0), Quaternion.identity);
            Destroy(tmpPlaneArmy, 20f);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
