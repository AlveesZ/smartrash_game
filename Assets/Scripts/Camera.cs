using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseLocalY = Input.GetAxis("Mouse Y") * -0.5f;
        transform.Rotate(mouseLocalY, 0.0f, 0.0f);
    }
}
