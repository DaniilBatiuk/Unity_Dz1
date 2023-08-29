using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;


public class Car : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public int count = 0;
    public Text MyCoin;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float right = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var pos = transform.position;
            pos += Vector3.up * Time.deltaTime * 250f;
            rigidbody.MovePosition(pos);
        }

        if (right != 0) {
            var pos = transform.position;
            pos += Vector3.right*right*Time.deltaTime*10;
            rigidbody.MovePosition(pos);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            count++;
            Destroy(collision.gameObject);
            MyCoin.text = "Coin" + count.ToString();
        }
    }
}
