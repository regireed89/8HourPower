using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
        {
            transform.position += transform.up;
        }
        if(Input.GetKey("a"))
        {
            transform.position += transform.right;
        }
	}
}
