//https://goodlucknetlife.com/unity-object-auto-move/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingMatox : MonoBehaviour
{
    private Vector3 targetpos;
    [SerializeField] float speed = 1.0f;
    [SerializeField] float range = 1.0f;
    void Start(){
        targetpos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(speed*Time.time) * range + targetpos.x, targetpos.y, targetpos.z);
    }
}
