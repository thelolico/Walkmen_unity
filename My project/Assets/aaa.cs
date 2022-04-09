using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class aaa : MonoBehaviour
{
    private Rigidbody myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    public void Update() {
        RigidbodyMove();
    }

    void RigidbodyMove(){
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        myRigidbody.AddForce(new Vector3(h,0,v)*10f);
    }
    
}