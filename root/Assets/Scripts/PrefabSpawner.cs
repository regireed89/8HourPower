using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PrefabSpawner : MonoBehaviour
{
    public GameObject Prefab;
    public float Timer;
    public float Cooldown;
    // Use this for initialization
    public virtual void Start () { }
	
	// Update is called once per frame
	public virtual void Update () {	}

    public List<GameObject> objectPool;
    public virtual void Spawn()    {}
}
