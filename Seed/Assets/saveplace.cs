using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveplace : MonoBehaviour {
    public Vector3 temsave;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            //存档
            PlayerPrefs.SetFloat("saveposi_x", transform.position.x);
        }
    }
}
