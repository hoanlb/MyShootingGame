using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameCommon : MonoBehaviour
{
    public TextMeshProUGUI BloodNumber;

    public int num = 100;

    public static GameCommon Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void BloodMinus(int num)
    {
        this.num = this.num - num;
        BloodNumber.text = this.num.ToString();
    }
}
