using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this entire class is completely, 100% useless but it's a reminder to do something later on

public class overtake : MonoBehaviour {
    public Text life;
    public int lifeleft;
	// Use this for initialization
	void Start () {
        lifeleft = 100;
	}
    private void OnCollisionEnter(Collision collision)
    {
        lifeleft = lifeleft - 1;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
