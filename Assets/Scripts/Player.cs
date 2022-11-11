using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    float playerVelocity = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent <Animator>();
    }

    void GetItem()
    {
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetBool("isGetting", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            animator.SetBool("isGetting", false);
        }
    }


    void PlayerMove()
    {
        float mouseLocalX = Input.GetAxis("Mouse X") * 10.0f;
        transform.Rotate(0.0f, mouseLocalX, 0.0f);

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isMoving", true);
            float verticalInput = Input.GetAxis("Vertical");
            Vector3 direction = new Vector3(0.0f, 0.0f, verticalInput);
            transform.Translate(direction * playerVelocity * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("isMoving", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        GetItem();
    }
}