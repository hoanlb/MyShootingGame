using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointUpdate : MonoBehaviour
{
    public int point = 0;
    public TextMeshProUGUI pointNumber;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Army")
        {
            GameCommon.Instance.AddPoint(5);
            Destroy(gameObject);
        }

        if (coll.gameObject.tag == "Bom")
        {
            GameCommon.Instance.AddPoint(15);
            Destroy(gameObject);
        }
    }
}
