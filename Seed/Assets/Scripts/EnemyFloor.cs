using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFloor : MonoBehaviour {
    private Rigidbody rig;
    public float MoveSpeed = 4.0f;
    private int look = 1;
    private Vector3 target1;
    private Vector3 target2;
    // Use this for initialization
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
        target1 = transform.position + new Vector3(10, 0, 0);
        target2 = transform.position - new Vector3(10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * MoveSpeed * look * Time.deltaTime, Space.World);
        if (transform.position.x >= target1.x || transform.position.x <= target2.x)
        {
            look = -look;
        }
    }
    private void FixedUpdate()
    {
        rig.AddForce(0, 1, 0);
    }
}
