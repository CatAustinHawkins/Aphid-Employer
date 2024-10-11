using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float jumpSpeed;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position += transform.right * -moveSpeed * Time.deltaTime;
            transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position += transform.right * moveSpeed * Time.deltaTime;
            transform.localScale = new Vector3(-0.25f, 0.25f, 0.25f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position += transform.up * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position += transform.up * -moveSpeed * Time.deltaTime;
        }
    }

}
