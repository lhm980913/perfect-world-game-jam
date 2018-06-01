using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaCtrTwo : MonoBehaviour {
    public float MoveSpeed = 1.0f;
    private bool OnFloor = true;

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
        //按A键，跳跃
        if ((Input.GetKeyDown(KeyCode.Joystick2Button0)||Input.GetKeyDown(KeyCode.J))&&OnFloor)
        {
            rig.velocity = new Vector3(0, -5, 0);
        }
        //按B键，拉
        if (Input.GetKeyDown(KeyCode.Joystick2Button1))
        {

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
