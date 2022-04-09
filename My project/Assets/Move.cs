using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    [SerializeField] float movespeed = 0f,jumphigher = 0f,jumptime = 100f,maxjumptime = 100f;
    [SerializeField] int tp_x = 8,tp_y = 15,tp_z = -1500;
    float pos,posx = 10f,posy = 3000f,posz = -1500f;
    //public Rigidbody  gr;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.W))
        // {
        //     if(movespeed < 0) movespeed *= -1;
        //     for(float i = 0f;i <= movespeed*Time.deltaTime;i++){
        //         transform.Translate(0,i*i,0);
        //     }
        // }
        int isjump = 0;
        pos = GetComponent <Transform> ().position.y;
        if(Input.GetKey(KeyCode.W))
        {
            if(movespeed < 0) movespeed *= -1;
            transform.Translate(0,0,movespeed*Time.deltaTime);
            //gr.MovePosition(0,0,movespeed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            if(movespeed < 0) movespeed *= -1;
            transform.Translate(movespeed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            if(movespeed > 0) movespeed *= -1;
            transform.Translate(movespeed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            if(movespeed > 0) movespeed *= -1;
            transform.Translate(0,0,movespeed*Time.deltaTime);
        }
        if(Input.GetKey("space"))
        {
            if(movespeed < 0) movespeed *= -1;
            if(jumptime >= 0)jumptime--;
            isjump = 1;
            if(jumptime > 0) transform.Translate(0,jumphigher*Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.P) || pos <= -100f)
        {
            transform.position = new Vector3(tp_x,tp_y,tp_z);
            //leg2 (mySpawner, transform.position, Quaternion.identity);
        }
        if(Input.GetKey(KeyCode.O))
        {
            posx = GetComponent <Transform> ().position.x;
            posy = GetComponent <Transform> ().position.y;
            posz = GetComponent <Transform> ().position.z;
        }
        if(Input.GetKey(KeyCode.I))
        {
            transform.position = new Vector3(posx,posy,posz);
        }

        if(jumptime < maxjumptime && isjump == 0){jumptime++;}
        //glColor4f(255,9,159,jumptime*2);
        //this.gameObject.GetComponent<Image> ().color = new Color(255,9,159,jumptime*2);
        GetComponent<MeshRenderer>().material.color = new Color(jumptime*2,0,0,255);
    }

    
}
