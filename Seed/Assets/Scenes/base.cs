using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class base_spawn : MonoBehaviour {
    public int stage;
    private Rigidbody rig;
	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		switch(stage)
        {
            case 0:
                {
                    rig.AddForce(new Vector3(0f,1f,0f), ForceMode.Acceleration);
                }
                break;
            case 1:
                {
                    rig.AddForce(new Vector3(0f, -1f, 0f), ForceMode.Acceleration);
                }
                break;
        }
        
	}
}
