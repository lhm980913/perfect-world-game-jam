using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class springToSummer : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        string str = "summer";
        if (other.tag == "Player")
        {
            other.gameObject.SendMessage("succeed", str);
        }
    }

}
