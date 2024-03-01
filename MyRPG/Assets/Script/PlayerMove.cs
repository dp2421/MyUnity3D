using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxisRaw("Horizontal");
        float vAxis = Input.GetAxisRaw("Vertical");


        Vector3 inputDir = new Vector3(hAxis, 0, vAxis).normalized;

        rb.velocity = inputDir * 10;

        transform.LookAt(transform.position + inputDir);
    }
}
