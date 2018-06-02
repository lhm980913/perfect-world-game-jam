using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour {
    public static int i = 0;
    public GameObject begin;
	// Use this for initialization
	void Awake () {
        if (i == 0)
        {
            PlayerPrefs.SetFloat("save_x", begin.transform.position.x);
            i++;
        }
        else;
	}
	
	// Update is called once per frame
	void Update () {
        //regame
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("main");
        }
        //clear all saveplace
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.DeleteAll();
        }
	}
}
