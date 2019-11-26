using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayChange : MonoBehaviour
{
    private BoxCollider2D bc;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("This is working.");
    }
}