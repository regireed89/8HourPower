
using UnityEngine;

public class CatSpawner : PrefabSpawner
{
    
    public override void Start()
    {
        Timer = 5f;
        Cooldown = 5f;
    }

    public override void Update()
    {
        
        if(Timer <= 0)
        {
            Spawn();
            Timer = Cooldown;
        }
            
        Timer -= Time.deltaTime;
    }

    public override void Spawn()
    {
        objectPool.Add(Instantiate(Prefab));
    }
}

