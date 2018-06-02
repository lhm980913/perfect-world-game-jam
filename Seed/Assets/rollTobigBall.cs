using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollTobigBall : MonoBehaviour {
    public float speed = 5;
    public float bigspeed = 1;
    public float rollspeed = 40;
    public int k;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(speed,k*bigspeed/2, 0) * Time.deltaTime, Space.World);
        transform.Rotate(new Vector3(0, 0, 1) * rollspeed*Time.deltaTime);
        transform.localScale += new Vector3(1, 1, 1) * bigspeed * Time.deltaTime;
	}
}
