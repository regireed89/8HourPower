using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject prefab;
    GameObject g;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space"))
        {
            g = Instantiate(prefab, transform, false);
            g.GetComponent<Rigidbody>().velocity += transform.TransformDirection(50, 0, 0);
            Destroy(g, 2);
        }
       
	}
}
