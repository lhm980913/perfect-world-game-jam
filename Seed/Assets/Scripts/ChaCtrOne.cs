using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChaCtrOne : MonoBehaviour {

    public float MoveSpeed = 1.0f;
    public Rigidbody target_2;
    public bool Onground = true;
    private Rigidbody rig;
    public float force;
    public bool la;
    public float pull;
    // Use this for initialization
    void Awake () {
        rig = GetComponent<Rigidbody>();
        //reset the player in the last saveplace
        transform.position = new Vector3(PlayerPrefs.GetFloat("save_x"), transform.position.y, 0);
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
          
        }
        //按A键，跳跃
        if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Z))
        {
            Vector3 dic = new Vector3();
            
            dic = (-target_2.position + transform.position) / Vector3.Distance(target_2.position, transform.position);
            if (la)
            {
                target_2.velocity += dic * pull;
                
            }
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button1) || Input.GetKeyUp(KeyCode.Z))
        {
           
                la = false;
            target_2.velocity = new Vector3(0f, target_2.velocity.y, 0f);
        }
        //按B键，拉
        if (Input.GetKey(KeyCode.Joystick1Button1)|| Input.GetKey(KeyCode.Z))
        {
            
            Vector3 dic = new Vector3();
            dic = (-target_2.position + transform.position) / Vector3.Distance(target_2.position, transform.position);

            target_2.AddForce(new Vector3(dic.x, 0f, 0f) * force * 1.5f, ForceMode.Force);
            if (target_2.velocity.y > 0)
            {
                target_2.AddForce(new Vector3(0f,dic.y,0f) * force * 1.5f, ForceMode.Force);
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
        target_2.gameObject.GetComponent<ChaCtrTwo>().la = true;
    }
    public void IsNotGround()
    {
        Onground = false;
        
    }
    public void death()
    {
        SceneManager.LoadScene("main");
    }
}
