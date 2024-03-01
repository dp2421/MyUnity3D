using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterStage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("제발 ..");
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌");
    }
}
