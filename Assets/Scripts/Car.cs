using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float right = Input.GetAxis("Horizontal");

        if(right != 0) {
            var pos = transform.position;
            pos += Vector3.right*right*Time.deltaTime*10;
            rigidbody.MovePosition(pos);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var pos = transform.position;
            pos += Vector3.up * Time.deltaTime * 50f;
            rigidbody.MovePosition(pos);
        }
    }
}
