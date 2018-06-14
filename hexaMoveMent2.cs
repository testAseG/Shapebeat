using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexaMoveMent2 : MonoBehaviour {
    int notes;
    int i;
    System.Random r = new System.Random();
    public GameObject gohexa;
    // Use this for initialization
    void Start () {
        notes = r.Next(1, 7);
    }
	
	// Update is called once per frame
	void Update () {
        i++;
        if (i > 35) Destroy(gohexa);
        if (notes == 1)
        {
            move0();
        }
        if (notes == 2)
        {
            move45();
        }
        if (notes == 3)
        {
            move135();
        }
        if (notes == 4)
        {
            move180();
        }
        if (notes == 5)
        {
            move225();
        }
        if (notes == 6)
        {
            move315();
        }
    }
    void move0()
    {
        Debug.Log("a");
        gohexa.transform.Translate(0, 3.5f, 0);
    }
    void move45()
    {
        gohexa.transform.position = new Vector3(2.525f, 2.525f, 0);
    }
    void move135()
    {
        gohexa.transform.position = new Vector3(2.525f, -2.525f, 0);
    }
    void move180()
    {
        gohexa.transform.position = new Vector3(0, -3.5f, 0);
    }
    void move225()
    {
        gohexa.transform.position = new Vector3(-2.525f, 2.525f, 0);
    }
    void move315()
    {
        gohexa.transform.position = new Vector3(-2.525f, -2.525f, 0);
    }
}
