using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kill : MonoBehaviour {
    public Text t;
    int count = 0;
    // Use this for initialization
    void Start () {
        t.text = "";
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            count++;
        }
        
      }
    // Update is called once per frame
    void Update () {
        t.text = "Kill Count " + count.ToString();
	}
}
