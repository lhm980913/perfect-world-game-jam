using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiaolou : MonoBehaviour {
    public check check;
    Rigidbody rig;
    public int fangxiang;
    public cccccc ccc;
    // Use this for initialization
    void Start()
    {
        check = GetComponentInChildren<check>();
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (check.filp)
        {
            //this.transform.Rotate(new Vector3(0, 180, 0));
        }
        if (ccc.run)
        {


        this.transform.position += (transform.right * 2.5f * Time.deltaTime * fangxiang);
        }
    }
}
