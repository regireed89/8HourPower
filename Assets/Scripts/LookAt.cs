using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {
    public Transform Target;
    public Vector3 startpos;
	// Use this for initialization
	void Start () {
        if(Target == null)
            Target = GameObject.FindGameObjectWithTag("Player").transform;

        startpos = transform.position;
        
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        var offset = Target.position.x - transform.position.x; 
        var newpos = new Vector3(transform.localPosition.x + offset, Target.localPosition.y, transform.localPosition.z);
        transform.localPosition = new Vector3(newpos.x, Target.localPosition.y, transform.position.z);
	}
}
