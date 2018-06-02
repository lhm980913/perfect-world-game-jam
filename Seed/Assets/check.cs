using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour {
    public bool filp = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        filp = false;
    }
    private void OnTriggerExit(Collider other)
    {
        filp = true;
    }
}
