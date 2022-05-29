using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camear : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    protected int c = 1;
    float z = 25f, y = -10;
    // Start is called before the first frame update
    void Start()
    {
        //offset = target.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) { c = -c; y = -10; z = 25; }
        if (c == -1)
        {
            if (Input.GetKey("up"))
            {
                if (y > -15.4) y -= 0.1f;
                //distanceAway = Origin_distanceAway;
            }

            if (Input.GetKey("down"))
            {
                if (y < -1) y += 0.1f;
                //distanceAway = Origin_distanceAway;
            }
            z = Mathf.Pow(729 - y*y,0.5f);
            offset = new Vector3(0, y, z);
            this.transform.position = target.position - offset;
        }
    }
}
