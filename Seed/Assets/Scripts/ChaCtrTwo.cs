using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChaCtrTwo : MonoBehaviour {
    public float MoveSpeed = 1.0f;
    public bool OnFloor = true;
    public Rigidbody target_1;
    public float force;
    public bool la;
    private Rigidbody rig;
    public float pull;
    private bool IsWater = false;

    public GameObject Player;
    private Animator anim;
    // Use this for initialization
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
        anim = Player.GetComponent<Animator>();
        
    }
    private void Start()
    {
        transform.position = new Vector3(PlayerPrefs.GetFloat("save_x"), transform.position.y, 0);
    }
    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Forward",Mathf.Abs(Input.GetAxis("2PLeft")));

        if (Input.GetAxis("2PLeft") != 0)
        {
            
            transform.Translate(Vector3.right * MoveSpeed * Input.GetAxis("2PLeft") * Time.deltaTime, Space.World);
            if(Input.GetAxis("2PLeft")>0)
            {
                Player.transform.localEulerAngles = new Vector3(180, -60, 0);
            }
            if (Input.GetAxis("2PLeft") < 0)
            {
                Player.transform.localEulerAngles = new Vector3(180, 60, 0);
            }
        }
        else
        {
           
        }
        //按A键，跳跃
        if (((Input.GetKeyDown(KeyCode.Joystick2Button0)||Input.GetKeyDown(KeyCode.J))&&OnFloor)&&!IsWater)
        {
            rig.velocity = new Vector3(0, -5, 0);
            anim.SetTrigger("Jump");
        }
        else if (((Input.GetKeyDown(KeyCode.Joystick2Button0) || Input.GetKeyDown(KeyCode.J)) && OnFloor) && IsWater)
        {
            rig.velocity = new Vector3(0, -2, 0);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button5) || Input.GetKeyDown(KeyCode.K))
        {
            Vector3 dic = new Vector3();
            dic = (-target_1.position + transform.position) / Vector3.Distance(target_1.position, transform.position);
            if (la)
            {
                target_1.velocity += dic * pull;
               
            }
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button5) || Input.GetKeyUp(KeyCode.K))
        {
            la = false;
            target_1.velocity = new Vector3(0f, target_1.velocity.y, 0f);
        }
        //按B键，拉
        if (Input.GetKey(KeyCode.Joystick2Button5) || Input.GetKey(KeyCode.K))
        {

            Vector3 dic = new Vector3();
            dic = (-target_1.position + transform.position) / Vector3.Distance(target_1.position, transform.position);
            target_1.AddForce(new Vector3(dic.x, 0f, 0f) * force * 1.5f, ForceMode.Force);
            if (target_1.velocity.y < 0)
            {
                target_1.AddForce(new Vector3(0f, dic.y, 0f) * force * 1.5f, ForceMode.Force);
            }
        }
    }
    private void FixedUpdate()
    {
        if (!OnFloor)
        {
            rig.AddForce(new Vector3(0, 10, 0));
        }
    }
    public void IsFloor()
    {
        anim.SetBool("Fall", false);
        OnFloor = true;
        target_1.gameObject.GetComponent<ChaCtrOne>().la = true;
    }
    public void IsNotFloor()
    {
        anim.SetBool("Fall", true);
        OnFloor = false;
       
    }
    public void death()
    {
        SceneManager.LoadScene("main");
    }
    public void InWater()
    {
        IsWater = true;
    }
    public void OutWater()
    {
        IsWater = false;
    }
}
