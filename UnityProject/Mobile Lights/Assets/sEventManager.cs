using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class sEventManager : MonoBehaviour
{
    private Dictionary<string, UnityEvent> eventDictionary;

    private static sEventManager eventManager;
    /*
    public static sEventManager instance
    {
        get
        {
            if(!eventManager)
            {
                eventManager = FindObjectOfType(typeof(sEventManager)) as sEventManager;
                
                if (!eventManager)
                {
                    Debug.LogError("There needs to be one active EventManager script on a GameObject in a scene");
                }
            }
        }
    }
    */
}
