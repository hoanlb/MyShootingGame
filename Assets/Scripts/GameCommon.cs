using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameCommon : MonoBehaviour
{
    public TextMeshProUGUI BloodNumber;

    public float num = 100;

    public static GameCommon Instance;

    public void BloodMinus(int num)
    {
        this.num = this.num - num;
        BloodNumber.text = this.num.ToString();
    }
}
