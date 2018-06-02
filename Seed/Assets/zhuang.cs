using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhuang : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
        player = GetComponentInParent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            player.SendMessage("death");
        }
    }
}
