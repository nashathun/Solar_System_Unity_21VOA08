using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform target;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate around the first target parameter position
        transform.RotateAround(target.transform.position, target.transform.up, speed  * Time.deltaTime);
    }
}