using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class stage1 : MonoBehaviour {
    int musicv;
    public int timer; //timer
    int j;
    public Text timetext;
    public Transform square;
    float[] spectrum= new float[512];
    public AudioSource stage1music;
    public GameObject mainhexa;     
	// Use this for initialization
	void Start () {
        mainhexa.SetActive(false);
       
    }
	
	// Update is called once per frame
	void Update () {
        if (musicv == 1)
        {
            MusicVisualization();
            musicv = 0;
        }
        else
        {
   
            musicv++;
        }
    }
    private void FixedUpdate()
    {
        Debug.Log("A");
        mainhexa.transform.Rotate(0f, 0f, 0.5f);
        j++;
        Debug.Log(timer);
        timetext.text = "" + timer;
        if(j%50==0)
        {
            timer++;
        }
        
 
    }
    void MusicVisualization()
    {
        stage1music.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);
       mainhexa.transform.localScale = new Vector3(spectrum[1]*2.2f + 2, spectrum[1]*2.2f+ 2, 1);

    }
}
 