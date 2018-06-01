using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaCtrOne : MonoBehaviour {
    public float MoveSpeed = 1.0f;
    public Rigidbody target_2;
    private bool Onground = true;
    private Rigidbody rig;
    public float force;
    bool la;
    // Use this for initialization
    void Awake () {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetAxis("1PLeft")!=0)
        {
            transform.Translate(Vector3.right * MoveSpeed* Input.GetAxis("1PLeft") * Time.deltaTime, Space.World);
            
        }
        else
        {
           rig.velocity = new Vector3(0f,rig.velocity.y, 0f);
        }
        //按A键，跳跃
        if (Input.GetKeyUp(KeyCode.Joystick1Button1) || Input.GetKeyUp(KeyCode.Z))
        {
            la = true;
        }
            //按B键，拉
        if (Input.GetKey(KeyCode.Joystick1Button1)|| Input.GetKey(KeyCode.Z))
        {
            
            Vector3 dic = new Vector3();
            dic = (-target_2.position + transform.position) / Vector3.Distance(target_2.position, transform.position);
            if (la)
            {
                target_2.velocity += dic * force;
                la = false;
            }
            if (target_2.velocity.y > 0)
            {
                target_2.AddForce(dic * force * 1.5f, ForceMode.Force);
            }
        }
        if ((Input.GetKeyDown(KeyCode.Space)||(Input.GetKeyDown(KeyCode.Joystick1Button0)))&&Onground)
        {
               
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
