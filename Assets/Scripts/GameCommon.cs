using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameCommon : MonoBehaviour
{
    public static GameCommon Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public TextMeshProUGUI pointNum;

    public int point = 0;

    public void AddPoint(int point)
    {
        this.point += point;
        pointNum.text = this.point.ToString();
    }
}
