using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camera1 : MonoBehaviour {
    public Transform target;

    public float distanceUp = 15f;
    public float distanceAway = 50f;
    public float smooth = 2f;
    public float camDepthSmooth = 5f;
    void Start(){}

    void Update(){
        if((Input.mouseScrollDelta.y < 0 && Camera.main.fieldOfView >= 3) || Input.mouseScrollDelta.y > 0 && Camera.main.fieldOfView <= 80)
        {
            Camera.main.fieldOfView += Input.mouseScrollDelta.y * camDepthSmooth *Time.deltaTime;
        }
    }

    void LateUpdate(){
        Vector3 disPos = target.position + Vector3.up * distanceUp -target.forward * distanceAway;
        transform.position = Vector3.Lerp(transform.position,disPos,Time.deltaTime*smooth);
    
        transform.LookAt(target.position);
    }
}
