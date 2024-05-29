using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BloodUpdate : MonoBehaviour
{
    public int num = 100;
    public TextMeshProUGUI bloodNumber;
    public GameObject gameOver;

    void Start()
    {
        Time.timeScale = 1;
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Army")
        {
            num -= 5;
            bloodNumber.text = num.ToString() + "/" + "100";
        }

        if (coll.gameObject.tag == "Bom")
        {
            num -= 15;
            bloodNumber.text = num.ToString() + "/" + "100";
        }

        if (num == 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
