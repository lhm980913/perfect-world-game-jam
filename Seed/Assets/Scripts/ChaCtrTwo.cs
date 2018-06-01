using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaCtrTwo : MonoBehaviour {
    public float MoveSpeed = 1.0f;
    private bool OnFloor = true;
    public Rigidbody target_1;
    public float force;
    bool la;
    private Rigidbody rig;
    // Use this for initialization
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("2PLeft") != 0)
        {
            transform.Translate(Vector3.right * MoveSpeed * Input.GetAxis("2PLeft") * Time.deltaTime, Space.World);
        }
        else
        {
            rig.velocity = new Vector3(0f, rig.velocity.y, 0f);
        }
        //按A键，跳跃
        if ((Input.GetKeyDown(KeyCode.Joystick2Button0)||Input.GetKeyDown(KeyCode.J))&&OnFloor)
        {
            rig.velocity = new Vector3(0, -5, 0);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button1) || Input.GetKeyUp(KeyCode.K))
        {
            la = true;
        }
        //按B键，拉
        if (Input.GetKey(KeyCode.Joystick1Button1) || Input.GetKey(KeyCode.K))
        {

            Vector3 dic = new Vector3();
            dic = (-target_1.position + transform.position) / Vector3.Distance(target_1.position, transform.position);
            if (la)
            {
                target_1.velocity += dic * force;
                la = false;
            }
            if (target_1.velocity.y < 0)
            {
                target_1.AddForce(dic * force * 1.5f, ForceMode.Force);
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
        OnFloor = true;
        print("YES!!!");
    }
    public void IsNotFloor()
    {
        OnFloor = false;
        print("NO!!!");
    }
}
