using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointUpdate : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Army")
        {
            Debug.Log("AddPoint 5");
            GameCommon.Instance.AddPoint(5);
            Destroy(gameObject);
        }

        if (coll.gameObject.tag == "Bom")
        {
            Debug.Log("AddPoint 15");
            GameCommon.Instance.AddPoint(15);
            Destroy(gameObject);
        }
    }
}
