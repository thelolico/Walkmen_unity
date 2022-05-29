using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camera1 : MonoBehaviour {
    [SerializeField] Transform target;

    [SerializeField] float distanceUp = 15f;
    [SerializeField] float distanceAway = 50f;
    [SerializeField] float smooth = 2f;
    [SerializeField] float camDepthSmooth = 5f;
    float Origin_distanceUp;

    protected int b = 1;
    //float Origin_distanceAway;
    void Start(){

        Origin_distanceUp = distanceUp;

        //Origin_distanceAway = distanceAway;
    }

    void Update(){
        if (b == 1)
        {
            if ((Input.mouseScrollDelta.y < 0 && Camera.main.fieldOfView >= 3) || Input.mouseScrollDelta.y > 0 && Camera.main.fieldOfView <= 80)
            {
                Camera.main.fieldOfView += Input.mouseScrollDelta.y * camDepthSmooth * Time.deltaTime;
            }
        }
    }

    void LateUpdate(){
        if (Input.GetKeyDown(KeyCode.K)) { b = -b; }
        if (b == 1)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                distanceUp = Origin_distanceUp;
                //distanceAway = Origin_distanceAway;
            }
            if (Input.GetKey("up"))
            {
                if (distanceUp < 90) distanceUp += 0.3f;
                //distanceAway = Origin_distanceAway;
            }

            if (Input.GetKey("down"))
            {
                if (distanceUp > 1) distanceUp -= 0.3f;
                //distanceAway = Origin_distanceAway;
            }

            Vector3 disPos = target.position + Vector3.up * distanceUp - target.forward * distanceAway;
            transform.position = Vector3.Lerp(transform.position, disPos, Time.deltaTime * smooth);

            transform.LookAt(target.position);
        }
    }
}
