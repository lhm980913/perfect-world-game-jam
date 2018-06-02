using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFloorSensor : MonoBehaviour {
    public CapsuleCollider capcol;

    private Vector3 point1;
    private Vector3 point2;
    private float radius;
    public float offset = 0.1f;
    // Use this for initialization
    void Awake()
    {
        radius = capcol.radius-0.4f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        point1 = transform.position - transform.up * (radius - 0.08f);
        point2 = transform.position - transform.up * capcol.height*0.1f + transform.up * radius;
        Collider[] outputCols = Physics.OverlapCapsule(point1, point2, radius, LayerMask.GetMask("Floor"));
        if (outputCols.Length != 0)
        {
            SendMessageUpwards("IsFloor");
        }
        else
        {
            SendMessageUpwards("IsNotFloor");
        }
    }
}
