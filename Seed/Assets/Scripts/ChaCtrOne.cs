﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaCtrOne : MonoBehaviour {
    public float MoveSpeed = 1.0f;

    private bool Onground = true;
    private Rigidbody rig;
	// Use this for initialization
	void Awake () {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("1PLeft")!=0)
        {
            transform.Translate(Vector3.right * MoveSpeed* Input.GetAxis("1PLeft") * Time.deltaTime, Space.World);
        }
        //按A键，跳跃
        if ((Input.GetKeyDown(KeyCode.Space)||(Input.GetKeyDown(KeyCode.Joystick1Button0)))&&Onground)
            {
            rig.velocity = new Vector3(0, 5, 0);
            }
        //按B键，拉
        if(Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
        }

	}
    private void FixedUpdate()
    {



        if (!Onground)
        {
            rig.AddForce(new Vector3(0, -10, 0));
        }
    }
    public void IsGround()
    {
        Onground = true;
       
    }
    public void IsNotGround()
    {
        Onground = false;
        
    }
}
