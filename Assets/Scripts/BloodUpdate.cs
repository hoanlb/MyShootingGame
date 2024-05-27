using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodUpdate : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("BloodUpdate");
        GameCommon.Instance.BloodMinus(10);
        Destroy(gameObject);
    }
}
