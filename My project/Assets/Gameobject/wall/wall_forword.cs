using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_forword : MonoBehaviour
{
    [SerializeField] float x,y,z;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(x, y, z+ target.position.z);
    }//target.position.z + 800
}
