using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hexaMoveMent : MonoBehaviour {
    System.Random r = new System.Random();
    int i,j;
    int notes,s;
    public GameObject hexa;
    public GameObject gohexa;
    
    // Use this for initialization

    private void Awake()
    {

    }
    void Start () {
		notes = r.Next(1, 7);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (j > 60) Destroy(hexa);
        if (j > 45)
        {
            hexa.transform.localScale += new Vector3(0.03f, 0.03f, 0);
        }
        if (notes == 1)
        {
            move_0(); 
        }
        if (notes == 2)
        {
            move_45();
        }
        if (notes == 3)
        {
            move_135();
        }
        if (notes == 4)
        {
            move_180();
        }
        if (notes == 5)
        {
            move_225();
        }
        if (notes == 6)
        {
            move_315();
        }
        j++;
    }
    void OnMouseDown() {
        if (j > 50 && j < 60)
        {
            s += 100;
            Destroy(hexa);
        }
        if (j > 40 && j < 50)
        {
            s += 70;
            Destroy(hexa);
        }
        if (j > 30 && j < 40)
        {
            s += 50;
            Destroy(hexa);
        }
        else Destroy(hexa);
        
    }
    void move_0()
    {
        if (i < 10)
        {
            hexa.transform.position += new Vector3(0, 0.2f, 0);
            i++;
        }
        else if (i < 20)
        {
            hexa.transform.position += new Vector3(0, 0.1f, 0);
            i++;
        }
        else if (i < 30)
        {
            hexa.transform.position += new Vector3(0, 0.05f, 0);
            i++;
        }
    }
    void move_45()
    {
        if (i < 10)
        {
            hexa.transform.position += new Vector3(0.13f, 0.13f, 0);
            i++;
        }
        else if (i < 20)
        {
            hexa.transform.position += new Vector3(0.0725f, 0.0725f, 0);
            i++;
        }
        else if (i < 30)
        {
            hexa.transform.position += new Vector3(0.05f, 0.05f, 0);
            i++;
        }
    }
    void move_135()
    {
        if (i < 10)
        {
            hexa.transform.position += new Vector3(0.13f, -0.13f, 0);
            i++;
        }
        else if (i < 20)
        {
            hexa.transform.position += new Vector3(0.0725f, -0.0725f, 0);
            i++;
        }
        else if (i < 30)
        {
            hexa.transform.position += new Vector3(0.05f, -0.05f, 0);
            i++;
        }
    }
    void move_180()
    {
        if (i < 10)
        {
            hexa.transform.position += new Vector3(0, -0.2f, 0);
            i++;
        }
        else if (i < 20)
        {
            hexa.transform.position += new Vector3(0,-0.1f, 0);
            i++;
        }
        else if (i < 30)
        {
            hexa.transform.position += new Vector3(0, -0.05f, 0);
            i++;
        }
    }
    void move_225()
    {
        if (i < 10)
        {
            hexa.transform.position += new Vector3(-0.13f, 0.13f, 0);
            i++;
        }
        else if (i < 20)
        {
            hexa.transform.position += new Vector3(-0.0725f, 0.0725f, 0);
            i++;
        }
        else if (i < 30)
        {
            hexa.transform.position += new Vector3(-0.05f, 0.05f, 0);
            i++;
        }
    }
    void move_315()
    {
        Debug.Log("a");
        if (i < 10)
        {
            hexa.transform.position += new Vector3(-0.13f, -0.13f, 0);
            i++;
        }
        else if (i < 20)
        {
            hexa.transform.position += new Vector3(-0.0725f, -0.0725f, 0);
            i++;
        }
        else if (i < 30)
        {
            hexa.transform.position += new Vector3(-0.05f, -0.05f, 0);
            i++;
        }
    }

}
