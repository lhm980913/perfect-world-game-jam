using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderToHurt : MonoBehaviour {

    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SendMessage("death");
        }
    }
}
