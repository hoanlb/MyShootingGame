using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public TextMeshProUGUI BloodNumber;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = (GameObject)(Instantiate(bullet, transform.position + transform.up * 1.5f, Quaternion.identity));
            b.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000);
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
    }
}
