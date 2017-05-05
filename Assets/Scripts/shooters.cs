using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooters : MonoBehaviour {
    public GameObject prefab;
   
    // Use this for initialization
    void Start () {
		for (int i = 0; i < 30; i++)
        {
            GameObject game = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
            game.transform.position = new Vector3(633, 250 + i , 0);
            Destroy(game.GetComponent<BoxCollider>());
            game.AddComponent<SpawnObj>();
            game.GetComponent<SpawnObj>().prefab = prefab;
        }
	}

    // Update is called once per frame
    void Update()
    {
    }
}
