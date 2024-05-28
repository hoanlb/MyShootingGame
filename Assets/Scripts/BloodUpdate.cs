using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodUpdate : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("BloodUpdate");
        GameCommon.Instance.BloodMinus(10);
    }
}
