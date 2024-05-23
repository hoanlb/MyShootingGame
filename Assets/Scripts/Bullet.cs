using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float existTime = 3;

    private float timer = 0;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= existTime)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Army")
        {
            Debug.Log("Start Destroy");
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }
}