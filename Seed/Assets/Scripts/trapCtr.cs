using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapCtr : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            other.gameObject.SendMessage("death");
        }
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other);
        }
    }
}
