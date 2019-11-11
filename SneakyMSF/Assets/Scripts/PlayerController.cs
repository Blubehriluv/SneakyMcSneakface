using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float runSpeed;
    private Rigidbody2D rb;
    private Transform tf;
    private float angle = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.A))
            {
                tf.position = tf.position + Vector3.left * runSpeed;
            }

            if (Input.GetKey(KeyCode.D))
            {
                tf.position = tf.position + Vector3.right * runSpeed;
            }

            if (Input.GetKey(KeyCode.W))
            {
                tf.position = tf.position + Vector3.up * runSpeed;
            }

            if (Input.GetKey(KeyCode.S))
            {
                tf.position = tf.position + Vector3.down * runSpeed;
            }
        }

        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                tf.position = tf.position + Vector3.left * speed;
            }

            if (Input.GetKey(KeyCode.D))
            {
                tf.position = tf.position + Vector3.right * speed;
            }

            if (Input.GetKey(KeyCode.W))
            {
                tf.position = tf.position + Vector3.up * speed;
            }

            if (Input.GetKey(KeyCode.S))
            {
                tf.position = tf.position + Vector3.down * speed;
            }
        }
        
    }
}
