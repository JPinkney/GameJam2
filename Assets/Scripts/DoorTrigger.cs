using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script triggers the locking of the door behind you when you enter a room 
 */
public class DoorTrigger : MonoBehaviour
{

    public GameObject door_obj;

    // Start is called before the first frame update
    void Start()
    {
        /*
         * We're grabbing and setting the door obj to false because Unity
         * doesn't allow you to find invisible objects
         */
        door_obj.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (door_obj)
        {
            door_obj.SetActive(true);
        }
    }
}
