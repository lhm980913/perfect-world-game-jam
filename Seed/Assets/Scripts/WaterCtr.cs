using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCtr : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            other.gameObject.SendMessage("InWater");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.SendMessage("OutWater");
    }
}
