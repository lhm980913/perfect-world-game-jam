using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaCtrOne : MonoBehaviour {
    public float MoveSpeed = 1.0f;
    private float SavePositionX;

    private bool Onground = true;
    private Rigidbody rig;
	// Use this for initialization
	void Awake () {
        rig = GetComponent<Rigidbody>();

        //重新开始时重生在存档位置play
        SavePositionX = PlayerPrefs.GetFloat("move");
        transform.position = new Vector3(SavePositionX, transform.position.y, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("1PLeft")!=0)
        {
            transform.Translate(Vector3.right * MoveSpeed* Input.GetAxis("1PLeft") * Time.deltaTime, Space.World);
        }
        //按A键，跳跃
        
        //按B键，拉
        if(Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            print("2");
        }
        if ((Input.GetKeyDown(KeyCode.Space)||(Input.GetKeyDown(KeyCode.Joystick1Button0)))&&Onground)
        {
            print("1");
            rig.velocity = new Vector3(0, 5, 0);
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
