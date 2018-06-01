using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaCtrTwo : MonoBehaviour {
    public float MoveSpeed = 1.0f;
    // Use this for initialization
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("2PLeft") != 0)
        {
            transform.Translate(Vector3.right * MoveSpeed * Input.GetAxis("2PLeft") * Time.deltaTime, Space.World);
        }
        //按A键，跳跃
        if (Input.GetKeyDown(KeyCode.Joystick2Button0))
        {

        }
        //按B键，拉
        if (Input.GetKeyDown(KeyCode.Joystick2Button1))
        {

        }
    }
}
