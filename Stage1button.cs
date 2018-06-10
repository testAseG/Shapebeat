using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Stage1button : MonoBehaviour {
    public GameObject hexagreen;
    public GameObject left;
    public GameObject right;
    public GameObject musictext;
    public GameObject Stagetext;
    public GameObject mainhexa;
	// Use this for initialization
	void Start () {
        GameObject.Find("cutstage1music").GetComponent<AudioSource>().Play();
    }
	
	// Update is called once per frame
	void Update () {
        hexagreen.transform.Rotate(0f, 0f, 0.5f);
	}
    private void OnMouseDown()
    {
        GameObject.Find("cutstage1music").GetComponent<AudioSource>().Stop();
       
        left.SetActive(false);
        right.SetActive(false);
        musictext.SetActive(false);
        Stagetext.SetActive(false);
        hexagreen.SetActive(false);
        mainhexa.SetActive(true);
        GameObject.Find("stage1music").GetComponent<AudioSource>().Play();
    }
}
