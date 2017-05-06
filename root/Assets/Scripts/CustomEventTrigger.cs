using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CustomEventTrigger : MonoBehaviour
{


    [System.Serializable]
    public class OnExitTrigger : UnityEvent { }
    [System.Serializable]
    public class OnEnterTrigger : UnityEvent { }
    [System.Serializable]
    public class OnStart : UnityEvent { }



    public OnExitTrigger onExitTrigger = new OnExitTrigger();
    public OnEnterTrigger onTriggerEnter = new OnEnterTrigger();
    public OnStart onStart = new OnStart();
    private void Start()
    {
        onStart.Invoke();
    }
    
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            onTriggerEnter.Invoke();
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            onExitTrigger.Invoke();
    }
}
