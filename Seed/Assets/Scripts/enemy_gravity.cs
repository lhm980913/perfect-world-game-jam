using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_gravity : MonoBehaviour {
    public bool isground;
    private Rigidbody rig;
	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(isground)
        {
            rig.AddForce(new Vector3(0, -10, 0));
        }
        else
        {
            rig.AddForce(new Vector3(0, 10, 0));
        }
	}
}
