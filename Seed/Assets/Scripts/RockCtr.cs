using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCtr : MonoBehaviour {
    public float MoveSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime, Space.World);
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
        }
    }
}
