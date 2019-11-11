using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        SetAnimationState();
    }

    void SetAnimationState()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("isWalkingFront", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("isWalkingFront", false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("isWalkingBack", true);

        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("isWalkingBack", false);
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("isWalkingLeft", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("isWalkingLeft", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("isWalkingRight", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("isWalkingRight", false);
        }
    }
}
