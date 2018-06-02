using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_walk : MonoBehaviour {
    public check check;
    Rigidbody rig;
    public int fangxiang = 1;
	// Use this for initialization
	void Start () {
        check = GetComponentInChildren<check>();
        rig = GetComponent<Rigidbody>();
        fangxiang = 1;
    }
	
	// Update is called once per frame
	void Update () {
		if(check.filp)
        {
            this.transform.Rotate(new Vector3(0, 180, 0));
        }
        this.transform.position += (transform.right * 2.5f*Time.deltaTime* fangxiang);
        
	}

}
