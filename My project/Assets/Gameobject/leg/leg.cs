using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leg : MonoBehaviour
{
    [SerializeField] float movespeed = 15f;
    // Start is called before the first frame update
    float pos,posx,posy ,posz;
    void Start()
    {
        posx = GetComponent <Transform> ().position.x;
            posy = GetComponent <Transform> ().position.y;
            posz = GetComponent <Transform> ().position.z;
    }

    // Update is called once per frame
    void Update()
    {
        pos = GetComponent <Transform> ().position.y;
        if(Input.GetKey(KeyCode.P))
        {
            transform.position = new Vector3(8,15,-1500);
            //leg2 (mySpawner, transform.position, Quaternion.identity);
        }
        if(pos <= -40f)
        {
            transform.position = new Vector3(-127,271,-806);
        }
        if(Input.GetKey(KeyCode.W))
        {
            if(movespeed < 0) movespeed *= -1;
            transform.Translate(0,0,movespeed*Time.deltaTime);
            //gr.MovePosition(0,0,movespeed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            if(movespeed > 0) movespeed *= -1;
            transform.Translate(0,0,movespeed*Time.deltaTime);
        }
    }
}
