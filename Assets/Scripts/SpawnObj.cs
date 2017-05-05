using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    public GameObject prefab;
    GameObject go;
    public float cooldown = 5f;
    public float timer = 5f;
    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            int r = Random.Range(10, 20) * -1;
            timer = cooldown;
            go = Instantiate(prefab, transform, false);
            go.GetComponent<Rigidbody>().velocity += transform.TransformDirection(r, 0, 0);        
        }
        timer -= Time.deltaTime;
        Destroy(go, 5);
    }
}
