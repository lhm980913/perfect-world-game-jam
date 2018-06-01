using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateByPoint : MonoBehaviour {
    public Transform point;
    public float rotatespeed = 40f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(point.position, new Vector3(0, 0, 1), rotatespeed * Time.deltaTime);
	}
}
